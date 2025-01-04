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
    public partial class frm_crearcontrato : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=\"E:\\SELLING PROJECTS\\MANEJADORINMUEBLE\\MAN_INMDB.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public frm_crearcontrato()
        {
            InitializeComponent();
        }

        private void createContract()
        {
            // Capturar los valores del formulario
            string propiedad = txt_propiedad.Text;
            string inquilino = txt_inquilino.Text;

            DateTime fechaInicio = DateTime.Parse(dtp_fechainicio.Text);
            DateTime fechaVencimiento = DateTime.Parse(dtp_fechavencimiento.Text);

            decimal montoPagar = decimal.Parse(txt_monto.Text);
            string frecuenciaPago = cb_frecuenciapago.SelectedItem.ToString();
            DateTime fechaPago = DateTime.Parse(dtp_fechapago.Text);

            decimal montoDeposito = decimal.Parse(txt_deposito.Text);
            string pdfRoute = txt_route.Text;

            byte[] pdfData = null;

            // Leer el archivo PDF y convertirlo a byte[]
            if (!string.IsNullOrEmpty(pdfRoute))
            {
                pdfData = File.ReadAllBytes(pdfRoute);
            }


            // Consulta SQL para insertar los datos en la tabla Contratos
            string query = @"
                INSERT INTO [dbo].[Contratos] 
                ([id_propiedad], [id_cliente], [fecha_inicio], [fecha_vencimiento], [monto_a_pagar], [frecuencia_pago], [fecha_pago], [monto_deposito], [documento_pdf])
                VALUES
                (@id_propiedad, @id_cliente, @fecha_inicio, @fecha_vencimiento, @monto_a_pagar, @frecuencia_pago, @fecha_pago, @monto_deposito, @documento_pdf)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros a la consulta
                    command.Parameters.AddWithValue("@id_propiedad", propiedad);  // Asegúrate de que txt_propiedad es el id de la propiedad
                    command.Parameters.AddWithValue("@id_cliente", inquilino);    // Asegúrate de que txt_inquilino es el id del cliente
                    command.Parameters.AddWithValue("@fecha_inicio", fechaInicio);
                    command.Parameters.AddWithValue("@fecha_vencimiento", fechaVencimiento);
                    command.Parameters.AddWithValue("@monto_a_pagar", montoPagar);
                    command.Parameters.AddWithValue("@frecuencia_pago", frecuenciaPago);
                    command.Parameters.AddWithValue("@fecha_pago", fechaPago);
                    command.Parameters.AddWithValue("@monto_deposito", montoDeposito);

                    // Si el archivo PDF fue cargado, agregarlo como parámetro
                    if (pdfData != null)
                    {
                        command.Parameters.AddWithValue("@documento_pdf", pdfData);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@documento_pdf", DBNull.Value);
                    }

                    try
                    {
                        // Abrir la conexión
                        connection.Open();
                        // Ejecutar la consulta
                        command.ExecuteNonQuery();
                        // Mostrar un mensaje de éxito
                        MessageBox.Show("Contrato agregado exitosamente.");
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier excepción
                        MessageBox.Show("Error al agregar el contrato: " + ex.Message);
                    }
                }
            }




        }
        private void btn_searchCli_Click(object sender, EventArgs e)
        {
            // Open frm_buscarcliente as a modal dialog
            using (frm_bProp searchForm = new frm_bProp())
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {
                    // Retrieve the selected Id_cliente after frm_buscarcliente is closed
                    string selectedIdPropiedad = searchForm.SelectedIdPropiedad;

                    // Display the selected Id_cliente in a TextBox or use it as needed
                    txt_propiedad.Text = selectedIdPropiedad;
                }
            }
        }

        private void btn_inquilino_Click(object sender, EventArgs e)
        {
            using (frm_buscInq searchForm = new frm_buscInq())
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {
                    // Retrieve the selected Id_cliente after frm_buscarcliente is closed
                    string selectedIdCliente = searchForm.SelectedIdCliente;

                    // Display the selected Id_cliente in a TextBox or use it as needed
                    txt_inquilino.Text = selectedIdCliente;
                }
            }

        }

        private void btn_addcontract_Click(object sender, EventArgs e)
        {
            // Crear una instancia de OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Configurar las propiedades del cuadro de diálogo
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Carpeta predeterminada
                openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf"; // Filtro para archivos PDF
                openFileDialog.Title = "Seleccionar archivo PDF";

                // Mostrar el cuadro de diálogo y verificar si el usuario selecciona un archivo
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ruta del archivo seleccionado
                    string rutaArchivoPDF = openFileDialog.FileName;

                    // Mostrar la ruta del archivo en un control, como un TextBox (opcional)
                    txt_route.Text = rutaArchivoPDF;

                    // O hacer cualquier otra cosa con la ruta del archivo seleccionado
                    MessageBox.Show("Archivo seleccionado: " + rutaArchivoPDF);
                }
            }
        }

        private void btn_createcontract_Click(object sender, EventArgs e)
        {
            createContract();
        }

        
    }
}
