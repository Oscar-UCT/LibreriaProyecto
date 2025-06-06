﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibreriaProyecto
{
    public partial class Busqueda : Form
    {
        int filaSeleccionada = -1;
        Form1 loginPrevio;
        Cliente clienteIngresado;
        DataTable tablaLibros = new DataTable("Libros");

        public Busqueda(Form1 loginPrevio, Cliente clienteIngresado)
        {
            InitializeComponent();

            // Carga inicial
            string consulta = "SELECT Nombre, Autor, Género, Año, Precio FROM Libros";
            using (SqlConnection conexion = new SqlConnection(@"Data Source=OSCAR-VICTUS;Initial Catalog=LibrosDB;Integrated Security=True;"))
            {
                conexion.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion))
                {
                    adapter.Fill(tablaLibros);
                    tablaBusqueda.DataSource = tablaLibros;

                    AjusteCustom();
                }
            }

            this.loginPrevio = loginPrevio;

            this.clienteIngresado = clienteIngresado;
            nombreLabel.Text = clienteIngresado.Nombre;
            correoLabel.Text = clienteIngresado.Correo;
            telefonoLabel.Text = clienteIngresado.Teléfono;

        }
        private void buscarBtn_Click(object sender, EventArgs e)
        {
            string busqueda = busquedaInput.Text.ToLower();
            string consulta = $"SELECT Nombre, Autor, Género, Año, Precio FROM Libros WHERE Nombre LIKE '%{busqueda}%' or Autor LIKE '%{busqueda}%' or Género LIKE '%{busqueda}%'";
            using (SqlConnection conexion = new SqlConnection(@"Data Source=OSCAR-VICTUS;Initial Catalog=LibrosDB;Integrated Security=True;"))
            {
                conexion.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion))
                {
                    tablaLibros.Clear();
                    adapter.Fill(tablaLibros);
                    tablaBusqueda.DataSource = tablaLibros;

                    AjusteCustom();
                }
            }
        }

        void AjusteCustom()
        {
            tablaBusqueda.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tablaBusqueda.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //tablaBusqueda.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            tablaBusqueda.CellFormatting += tablaBusqueda_CellFormatting;
        }

        private void tablaBusqueda_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                if (e.Value is int Año)
                {
                    if (Año < 0)
                    {
                        e.Value = $"{Math.Abs(Año)} A.C";
                    }
                }
            }
            else if (e.ColumnIndex == 4 && e.Value != null)
            {
                if (e.Value is int Precio)
                {
                    e.Value = Precio.ToString("C");
                }
            }

        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            loginPrevio.Show();
            this.Dispose();
        }

        private void Busqueda_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginPrevio.Close();
        }

        private void tablaBusqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
            if (filaSeleccionada > -1 )
            {
                filaSeleccionada = e.RowIndex;
                libroSeleccionLabel.Text = tablaBusqueda.Rows[filaSeleccionada].Cells[0].Value.ToString();
                precioLabel.Text = $"${tablaBusqueda.Rows[filaSeleccionada].Cells[4].Value}";
            }
        }

        private void comprarBtn_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada > -1)
            {
                DialogResult confirmacion = MessageBox.Show($"Desea comprar libro {libroSeleccionLabel.Text} a ${precioLabel.Text.Substring(1)}?", "Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                using (SqlConnection conexion = new SqlConnection(@"Data Source=OSCAR-VICTUS;Initial Catalog=LibrosDB;Integrated Security=True;"))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("AñadirPedido", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NombreLibro", libroSeleccionLabel.Text);
                        cmd.Parameters.AddWithValue("@NombreCliente", clienteIngresado.Nombre);
                        cmd.Parameters.AddWithValue("@Precio", precioLabel.Text.Substring(1));
                        cmd.ExecuteNonQuery();
                    }
                }
                    MessageBox.Show($"Usted ha comprado el libro: {libroSeleccionLabel.Text}", "Compra confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}
