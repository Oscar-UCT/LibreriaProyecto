using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibreriaProyecto
{
    public partial class Administración : Form
    {
        Form1 loginPrevio;
        DataTable tablaLibros = new DataTable();
        DataTable tablaPedidos = new DataTable();
        int indiceSeleccionado = -1;
        int indiceBaseDatos = -1;
        int pedidoSeleccionado = -1;

        public Administración(Form1 loginPrevio)
        {
            InitializeComponent();

            // Carga Inicial
            string consulta = "SELECT * FROM Libros";
            using (SqlConnection conexion = new SqlConnection(@"Data Source=OSCAR-VICTUS;Initial Catalog=LibrosDB;Integrated Security=True;"))
            {
                conexion.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion))
                {
                    adapter.Fill(tablaLibros);
                    tablaAdmin.DataSource = tablaLibros;

                    AjusteCustom();
                }
            }
            string consulta2 = "SELECT * FROM Pedidos";
            using (SqlConnection conexion = new SqlConnection(@"Data Source=OSCAR-VICTUS;Initial Catalog=LibrosDB;Integrated Security=True;"))
            {
                conexion.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(consulta2, conexion))
                {
                    adapter.Fill(tablaPedidos);
                    tablaPedidosForm.DataSource = tablaPedidos;

                    AjusteCustom();
                }
            }
            this.loginPrevio = loginPrevio;
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(@"Data Source=OSCAR-VICTUS;Initial Catalog=LibrosDB;Integrated Security=True;"))
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("BuscarLibros", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (nombreInput.Text != "")
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombreInput.Text);
                    }

                    if (autorInput.Text != "")
                    {
                        cmd.Parameters.AddWithValue("@Autor", autorInput.Text);
                    }

                    if (generoInput.Text != "")
                    {
                        cmd.Parameters.AddWithValue("@Género", generoInput.Text);
                    }

                    if (añoInput.Text != "")
                    {
                        cmd.Parameters.AddWithValue("@Año", añoInput.Text);
                    }

                    if (precioInput.Text != "")
                    {
                        cmd.Parameters.AddWithValue("@Precio", precioInput.Text);
                    }


                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        tablaLibros.Clear();

                        adapter.Fill(tablaLibros);
                        tablaAdmin.DataSource = tablaLibros;

                        AjusteCustom();
                    }
                }
            }
        }

        private void añadirBtn_Click(object sender, EventArgs e)
        {
            if (DatosValidos())
            {
                using (SqlConnection conexion = new SqlConnection(@"Data Source=OSCAR-VICTUS;Initial Catalog=LibrosDB;Integrated Security=True;"))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("AñadirLibro", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Nombre", nombreInput.Text);
                        cmd.Parameters.AddWithValue("@Autor", autorInput.Text);
                        cmd.Parameters.AddWithValue("@Género", generoInput.Text);
                        cmd.Parameters.AddWithValue("@Año", añoInput.Text);
                        cmd.Parameters.AddWithValue("@Precio", precioInput.Text);
                        cmd.ExecuteNonQuery();

                        string consulta = "SELECT * FROM Libros";
                        using (SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion))
                        {
                            tablaLibros.Clear();
                            adapter.Fill(tablaLibros);
                            tablaAdmin.DataSource = tablaLibros;

                            indiceSeleccionado = -1;
                            indiceBaseDatos = -1;
                            AjusteCustom();
                            LimpiarCampos();
                        }
                    }
                }
                MessageBox.Show("Libro Ingresado Con Éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void añoInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (!int.TryParse(añoInput.Text, out _) && añoInput.Text != "")
            {
                añoInvalidoLabel.Visible = true;
            }
            else
            {
                añoInvalidoLabel.Visible = false;
            }
        }
        private void precioInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (!int.TryParse(precioInput.Text, out _) && precioInput.Text != "")
            {
                precioInvalidoLabel.Visible = true;
            }
            else
            {
                precioInvalidoLabel.Visible = false;
            }
        }

        bool DatosValidos()
        {
            if (!int.TryParse(añoInput.Text, out _) && añoInput.Text != "")
            {
                MessageBox.Show("Ingrese un año válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(precioInput.Text, out _) && precioInput.Text != "")
            {
                MessageBox.Show("Ingrese un precio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (nombreInput.TextLength > 0 &&
                autorInput.TextLength > 0 &&
                generoInput.TextLength > 0 &&
                añoInput.TextLength > 0 &&
                precioInput.TextLength > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Rellene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            if (indiceSeleccionado > -1)
            {
                avisoSeleccione.Visible = false;

                if (CambiosDetectados())
                {
                    DialogResult confimarEdit = MessageBox.Show($"¿Confirmar cambios?\nNombre: {nombreInput.Text}\nAutor: {autorInput.Text}\nGénero: {generoInput.Text}\nAño: {añoInput.Text}\nPrecio: {precioInput.Text}", "Editar fila", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (confimarEdit == DialogResult.Yes)
                    {
                        using (SqlConnection conexion = new SqlConnection(@"Data Source=OSCAR-VICTUS;Initial Catalog=LibrosDB;Integrated Security=True;"))
                        {
                            conexion.Open();
                            using (SqlCommand cmd = new SqlCommand("EditarFila", conexion))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.AddWithValue("@ID", indiceBaseDatos);
                                cmd.Parameters.AddWithValue("@Nombre", nombreInput.Text);
                                cmd.Parameters.AddWithValue("@Autor", autorInput.Text);
                                cmd.Parameters.AddWithValue("@Género", generoInput.Text);
                                cmd.Parameters.AddWithValue("@Año", añoInput.Text);
                                cmd.Parameters.AddWithValue("@Precio", precioInput.Text);

                                cmd.ExecuteNonQuery();
                            }

                            string consulta = "SELECT * FROM Libros";
                            using (SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion))
                            {
                                tablaLibros.Clear();

                                adapter.Fill(tablaLibros);
                                tablaAdmin.DataSource = tablaLibros;

                                tablaAdmin.Rows[indiceSeleccionado].Selected = true;

                                AjusteCustom();
                            }
                            MessageBox.Show($"Se ha cambiado el registro ID: {indiceBaseDatos} con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se detectaron cambios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                avisoSeleccione.Visible = true;
            }
        }
        bool CambiosDetectados()
        {
            if (indiceSeleccionado > -1)
            {
                if (nombreInput.Text != tablaAdmin.Rows[indiceSeleccionado].Cells[1].Value.ToString() ||
                    autorInput.Text != tablaAdmin.Rows[indiceSeleccionado].Cells[2].Value.ToString() ||
                    generoInput.Text != tablaAdmin.Rows[indiceSeleccionado].Cells[3].Value.ToString() ||
                    añoInput.Text != tablaAdmin.Rows[indiceSeleccionado].Cells[4].Value.ToString() ||
                    precioInput.Text != tablaAdmin.Rows[indiceSeleccionado].Cells[5].Value.ToString()
                    )
                {
                    return true;
                }
            }
            return false;
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (indiceSeleccionado > -1)
            {
                avisoSeleccione.Visible = false;

                DialogResult confirmarEliminar = MessageBox.Show($"¿Confirma eliminar registro ID: {indiceBaseDatos}?", "Eliminar fila", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (confirmarEliminar == DialogResult.Yes)
                {
                    using (SqlConnection conexion = new SqlConnection(@"Data Source=OSCAR-VICTUS;Initial Catalog=LibrosDB;Integrated Security=True;"))
                    {
                        conexion.Open();
                        using (SqlCommand cmd = new SqlCommand("EliminarLibro", conexion))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ID", indiceBaseDatos);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show($"Libro ID: {indiceBaseDatos} se ha eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string consulta = "SELECT * FROM Libros";
                        using (SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion))
                        {
                            tablaLibros.Clear();
                            adapter.Fill(tablaLibros);
                            tablaAdmin.DataSource = tablaLibros;

                            indiceSeleccionado = -1;
                            indiceBaseDatos = -1;
                            AjusteCustom();
                            LimpiarCampos();
                        }
                    }
                }
            }
            else
            {
                avisoSeleccione.Visible = true;
            }
        }
        void AjusteCustom()
        {
            tablaAdmin.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tablaAdmin.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //tablaBusqueda.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        void LimpiarCampos()
        {
            nombreInput.Text = "";
            autorInput.Text = "";
            generoInput.Text = "";
            añoInput.Text = "";
            precioInput.Text = "";
        }

        private void tablaAdmin_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LimpiarCampos();
        }

        private void tablaAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceSeleccionado = e.RowIndex;
            if (indiceSeleccionado > -1)
            {
                indiceBaseDatos = Convert.ToInt32(tablaAdmin.Rows[indiceSeleccionado].Cells[0].Value);

                nombreInput.Text = tablaAdmin.Rows[indiceSeleccionado].Cells[1].Value.ToString();
                autorInput.Text = tablaAdmin.Rows[indiceSeleccionado].Cells[2].Value.ToString();
                generoInput.Text = tablaAdmin.Rows[indiceSeleccionado].Cells[3].Value.ToString();
                añoInput.Text = tablaAdmin.Rows[indiceSeleccionado].Cells[4].Value.ToString();
                precioInput.Text = tablaAdmin.Rows[indiceSeleccionado].Cells[5].Value.ToString();

                avisoSeleccione.Visible = false;
                // No toma en cuenta el orden visible de la tabla
                //nombreInput.Text = tablaLibros.Rows[indiceSeleccionado][1].ToString();
                //autorInput.Text = tablaLibros.Rows[indiceSeleccionado][2].ToString();
                //generoInput.Text = tablaLibros.Rows[indiceSeleccionado][3].ToString();
                //añoInput.Text = tablaLibros.Rows[indiceSeleccionado][4].ToString();
                //precioInput.Text = tablaLibros.Rows[indiceSeleccionado][5].ToString();

            }
        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            loginPrevio.Show();
            this.Dispose();
        }

        private void Administración_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginPrevio.Close();
        }

        private void buscarPedidoBtn_Click(object sender, EventArgs e)
        {
            List<string> camposRellenados = new List<string>();
            if (clienteInput.Text != "")
            {
                camposRellenados.Add($"Cliente LIKE '%{clienteInput.Text}%'");
            }
            if (libroPedidoInput.Text != "")
            {
                camposRellenados.Add($"Libro LIKE '%{libroPedidoInput.Text}%'");
            }

            tablaPedidos.DefaultView.RowFilter = $"{string.Join(" AND ", camposRellenados)}";
        }

        private void tablaPedidosForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pedidoSeleccionado = e.RowIndex;
            if (pedidoSeleccionado > -1)
            {
                using (SqlConnection conexion = new SqlConnection(@"Data Source=OSCAR-VICTUS;Initial Catalog=LibrosDB;Integrated Security=True;"))
                {
                    conexion.Open();
                    using (SqlCommand cmd = conexion.CreateCommand())
                    {
                        cmd.CommandText = $"SELECT Nombre, Correo, Teléfono FROM Usuarios WHERE Nombre = '{tablaPedidosForm.Rows[pedidoSeleccionado].Cells[2].Value}'";
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                nombreLabel.Text = reader.GetString(0);
                                correoLabel.Text = reader.GetString(1);
                                telefonoLabel.Text = reader.GetString(2);

                                nombreLabel.Visible = true;
                                correoLabel.Visible = true;
                                telefonoLabel.Visible = true;
                                seleccionePedidoLabel.Visible = false;
                            }
                        }
                    }
                }
            }
        }

        private void tablaPedidosForm_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = $"${e.Value}";
            }
        }
    }
}
