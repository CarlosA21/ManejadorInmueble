using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorInmueble
{
    public partial class frm_alquiler : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=\"E:\\SELLING PROJECTS\\MANEJADORINMUEBLE\\MAN_INMDB.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public frm_alquiler()
        {
            InitializeComponent();
            
        }
        private void LoadContractData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT id_contrato, id_propiedad, id_cliente, fecha_inicio, fecha_vencimiento, monto_a_pagar, frecuencia_pago, fecha_pago, monto_deposito FROM contratos";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    dtg_proxAlq.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_crearalquiler_Click(object sender, EventArgs e)
        {
            frm_crearcontrato frm_Crearcontrato = new frm_crearcontrato();

            frm_Crearcontrato.Show();
        }
        private void AddOpenPdfButtonColumn()
        {
            // Create a new button column
            DataGridViewButtonColumn openPdfButtonColumn = new DataGridViewButtonColumn();
            openPdfButtonColumn.Name = "openPdfButton";
            openPdfButtonColumn.HeaderText = "Open PDF";
            openPdfButtonColumn.Text = "Open PDF";
            openPdfButtonColumn.UseColumnTextForButtonValue = true; // Display "Open PDF" on each button

            // Add the button column to the DataGridView
            dtg_proxAlq.Columns.Add(openPdfButtonColumn);
        }

        private void frm_alquiler_Load(object sender, EventArgs e)
        {
            // Add the "Open PDF" button column
            LoadContractData();

            if (!dtg_proxAlq.Columns.Contains("btnPDF"))
            {
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.HeaderText = "Acciones";
                btnEdit.Name = "btnPDF";
                btnEdit.Text = "Ver PDF";
                btnEdit.UseColumnTextForButtonValue = true;
                dtg_proxAlq.Columns.Add(btnEdit);
            }

            // Hook up the CellClick event to handle button clicks
            dtg_proxAlq.CellClick += dtg_proxAlq_CellClick;
        }


        private void dtg_proxAlq_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            // Check if the clicked cell is part of the "Open PDF" button column
            if (e.ColumnIndex == dtg_proxAlq.Columns["btnPDF"].Index && e.RowIndex >= 0)
            {
                // Retrieve the binary PDF data from the "documento_pdf" column of the selected row
                if (dtg_proxAlq.Rows[e.RowIndex].Cells["btnPDF"].Value != DBNull.Value)
                {
                    byte[] pdfData = dtg_proxAlq.Rows[e.RowIndex].Cells["btnPDF"].Value as byte[];

                    if (pdfData != null && pdfData.Length > 0)
                    {
                        // Create a temporary file to store the PDF
                        string tempFilePath = Path.Combine(Path.GetTempPath(), "temp_contract.pdf");

                        // Write the binary data to the temp file
                        File.WriteAllBytes(tempFilePath, pdfData);

                        // Open the PDF file using the default PDF viewer
                        Process.Start(tempFilePath);
                    }
                    else
                    {
                        MessageBox.Show("No PDF data available for this contract.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No PDF data available for this contract.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}

