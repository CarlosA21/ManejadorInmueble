using Microsoft.Data.SqlClient;

namespace ManejadorInmueble
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();

        }
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=\"E:\\SELLING PROJECTS\\MANEJADORINMUEBLE\\MAN_INMDB.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usuario = txt_user.Text.Trim();
            string nombreUsuario = txt_user.Text;

            string password = txt_pass.Text.Trim(); // Asegúrate de limpiar los espacios en blanco

            frm_main main = new frm_main(usuario);


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta SQL para verificar el usuario y la contraseña
                    string query = "SELECT Usuario FROM Usuarios WHERE Usuario = @usuario AND password = @password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@usuario", usuario);
                        command.Parameters.AddWithValue("@password", password);

                        // Ejecutar la consulta y leer el resultado
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Si hay un registro, las credenciales son correctas
                                MessageBox.Show("Inicio de sesión exitoso.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                main.Show();
                                this.Hide();
                            }
                            else
                            {
                                // Si no hay registros, las credenciales son incorrectas
                                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
