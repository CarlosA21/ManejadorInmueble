using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorInmueble
{
    public partial class frm_buscarcliente : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=\"E:\\SELLING PROJECTS\\MANEJADORINMUEBLE\\MAN_INMDB.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public string SelectedIdCliente { get; private set; }


        public frm_buscarcliente()
        {
            InitializeComponent();
        }
        private void LoadClientData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM cliente WHERE CAST(tipo_cliente AS VARCHAR(MAX)) = 'propietario'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    dtg_prop.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_buscarcliente_Load(object sender, EventArgs e)
        {
            LoadClientData();
        }

        private void dtg_prop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is selected
            {
                // Get the Id_cliente from the selected row
                SelectedIdCliente = dtg_prop.Rows[e.RowIndex].Cells["Id_cliente"].Value.ToString();

                // Close the form with DialogResult.OK to indicate a successful selection
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dtg_prop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
