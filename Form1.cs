using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibreriaProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ingresoBtn_Click(object sender, EventArgs e)
        {
            Cliente clienteDatos;

            if (usuarioInput.Text == "admin" && contraseñaInput.Text == "admin")
            {
                avisoRellene.Visible = false;

                Administración adminForm = new Administración(this);
                this.Hide();
                adminForm.Show();
            }
            else if (usuarioInput.Text != "" && contraseñaInput.Text != "")
            {
                avisoRellene.Visible = false;

                bool usuarioEncontrado = false;
                using (SqlConnection conexion = new SqlConnection(@"Data Source=OSCAR-VICTUS;Initial Catalog=LibrosDB;Integrated Security=True;"))
                {
                    conexion.Open();
                    using (SqlCommand cmd = conexion.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM Usuarios";
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (usuarioInput.Text == reader.GetString(1) && contraseñaInput.Text == reader.GetString(2))
                                {
                                    usuarioEncontrado = true;
                                    clienteDatos = new Cliente(reader.GetString(1), reader.GetString(3), reader.GetString(4));
                                    Busqueda busquedaForm = new Busqueda(this, clienteDatos);
                                    this.Hide();
                                    busquedaForm.Show();
                                }
                            }
                        }
                    }
                    if (!usuarioEncontrado)
                    {
                        MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //MessageBox.Show("Ingreso Exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                avisoRellene.Visible = true;
            }
        }

        private void registrarBtn_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro(this);
            this.Hide();
            registro.Show();
        }
    }
}
