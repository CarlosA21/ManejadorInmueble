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
    public partial class frm_buscInq : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=\"E:\\SELLING PROJECTS\\MANEJADORINMUEBLE\\MAN_INMDB.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public string SelectedIdCliente { get; private set; }

        public frm_buscInq()
        {
            InitializeComponent();
            LoadClientData();
        }

        private void LoadClientData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM cliente WHERE CAST(tipo_cliente AS VARCHAR(MAX)) = 'inquilino'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    dtg_inq.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

        private void frm_buscInq_Load(object sender, EventArgs e)
        {

        }

        private void dtg_inq_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is selected
            {
                // Get the Id_cliente from the selected row
                SelectedIdCliente = dtg_inq.Rows[e.RowIndex].Cells["Id_cliente"].Value.ToString();

                // Close the form with DialogResult.OK to indicate a successful selection
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
