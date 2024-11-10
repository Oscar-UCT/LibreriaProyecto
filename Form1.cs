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
                        cmd.CommandText = "SELECT Nombre, Contraseña FROM Usuarios";
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (usuarioInput.Text == reader.GetString(0) && contraseñaInput.Text == reader.GetString(1))
                                {
                                    usuarioEncontrado = true;
                                }
                            }
                        }
                    }
                    if (usuarioEncontrado)
                    {
                        MessageBox.Show("Ingreso Exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Busqueda busquedaForm = new Busqueda(this);
                        this.Hide();
                        busquedaForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario No Encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                avisoRellene.Visible = true;
            }
        }
    }
}
