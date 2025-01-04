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
    public partial class frm_bProp : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=\"E:\\SELLING PROJECTS\\MANEJADORINMUEBLE\\MAN_INMDB.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public string SelectedIdPropiedad { get; private set; }

        public frm_bProp()
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

                    string query = "SELECT * FROM propiedades;";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    dtg_inquilino.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }
        private void frm_bProp_Load(object sender, EventArgs e)
        {

        }

        private void dtg_inquilino_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is selected
            {
                // Get the Id_cliente from the selected row
                SelectedIdPropiedad = dtg_inquilino.Rows[e.RowIndex].Cells["id_propiedad"].Value.ToString();

                // Close the form with DialogResult.OK to indicate a successful selection
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
