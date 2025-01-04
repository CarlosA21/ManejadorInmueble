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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ManejadorInmueble
{
    public partial class frm_propiedades : Form
    {
        public frm_propiedades()
        {
            InitializeComponent();
        }



        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=\"E:\\SELLING PROJECTS\\MANEJADORINMUEBLE\\MAN_INMDB.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"; // Aquí va la cadena de conexión a tu base de datos

        private void addProperty()
        {
            string hab = cb_habitaciones.SelectedItem.ToString();    // Número de habitaciones
            string bath = cb_bath.SelectedItem.ToString();           // Número de baños
            string estadoP = cb_estadoP.SelectedItem.ToString();     // Estado de la propiedad
            string tipoP = cb_tipoPropiedad.SelectedItem.ToString(); // Tipo de propiedad
            string propietario = txt_propietario.Text;               // Información del propietario


            string direccion = txt_direccion.Text;                   // Dirección de la propiedad
            string ciudad = txt_ciudad.Text;                         // Ciudad
            string estado = txt_estado.Text;                         // Estado (región)
            decimal precio = decimal.Parse(txt_precio.Text);         // Precio de la propiedad
            string size = txt_size.Text;                 // Tamaño de la propiedad
            string descripcion = txt_descripcion.Text;               // Descripción de la propiedad

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    INSERT INTO Propiedades 
                    (id_cliente, tipo_propiedad, direccion, ciudad, estado, precio, tamano, habitaciones, banos, estado_propiedad, descripcion)
                    VALUES 
                    (@propietario, @tipo_propiedad, @direccion, @ciudad, @estado, @precio, @tamano, @habitaciones, @banos, @estado_propiedad, @descripcion);";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@propietario", propietario);
                command.Parameters.AddWithValue("@tipo_propiedad", tipoP);
                command.Parameters.AddWithValue("@direccion", direccion);
                command.Parameters.AddWithValue("@ciudad", ciudad);
                command.Parameters.AddWithValue("@estado", estado);
                command.Parameters.AddWithValue("@precio", precio);
                command.Parameters.AddWithValue("@tamano", size);
                command.Parameters.AddWithValue("@habitaciones", hab);
                command.Parameters.AddWithValue("@banos", bath);
                command.Parameters.AddWithValue("@estado_propiedad", estadoP);
                command.Parameters.AddWithValue("@descripcion", descripcion);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Propiedad insertada exitosamente.");
                        LoadPropertyData();
                        CleanPropertyData();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo insertar la propiedad.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar la propiedad: " + ex.Message);
                }
            }

        }

        private void editProperty()
        {
            string id = txt_id.Text;
            string hab = cb_habitaciones.SelectedItem.ToString();             // Número de habitaciones
            string bath = cb_bath.SelectedItem.ToString();           // Número de baños
            string estadoP = cb_estadoP.SelectedItem.ToString();     // Estado de la propiedad
            string tipoP = cb_tipoPropiedad.SelectedItem.ToString(); // Tipo de propiedad
            string propietario = txt_propietario.Text;               // Información del propietario

            string direccion = txt_direccion.Text;                   // Dirección de la propiedad
            string ciudad = txt_ciudad.Text;                         // Ciudad
            string estado = txt_estado.Text;                         // Estado (región)
            decimal precio = decimal.Parse(txt_precio.Text);         // Precio de la propiedad
            string size = txt_size.Text;                 // Tamaño de la propiedad
            string descripcion = txt_descripcion.Text;               // Descripción de la propiedad

            // Actualizar en la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string updateQuery = @"UPDATE Propiedades 
                               SET direccion = @direccion, 
                                   ciudad = @ciudad, 
                                   estado = @estado, 
                                   tipo_propiedad = @tipo_propiedad, 
                                   precio = @precio, 
                                   tamano = @tamano, 
                                   habitaciones = @habitaciones, 
                                   banos = @banos, 
                                   estado_propiedad = @estado_propiedad, 
                                   descripcion = @descripcion 
                               WHERE id_propiedad = @id_propiedad";

                    SqlCommand command = new SqlCommand(updateQuery, connection);

                    // Asumiendo que ya tienes los valores en variables correspondientes
                    command.Parameters.AddWithValue("@id_propiedad", id);  // ID de la propiedad
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@ciudad", ciudad);
                    command.Parameters.AddWithValue("@estado", estado);
                    command.Parameters.AddWithValue("@tipo_propiedad", tipoP);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@tamano", size);
                    command.Parameters.AddWithValue("@habitaciones", hab);
                    command.Parameters.AddWithValue("@banos", bath);
                    command.Parameters.AddWithValue("@estado_propiedad", estadoP);
                    command.Parameters.AddWithValue("@descripcion", descripcion);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Propiedad actualizada exitosamente.");
                        // Recargar el DataGridView
                        LoadPropertyData();
                        CleanPropertyData();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la propiedad.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la propiedad: " + ex.Message);
                }
            }

        }

        private void eraseProperty()
        {
            string idPropiedad = dtg_propiedades.SelectedRows[0].Cells["id_propiedad"].Value.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM propiedades WHERE id_propiedad = @id_propiedad";
                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@id_propiedad", idPropiedad);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Propiedad eliminada exitosamente.");

                    // Actualizar el DataGridView
                    LoadPropertyData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar propiedad: " + ex.Message);
                }
            }
        }


        private void FiltrarPropiedades(string filtro)
        {
            // Verifica si el DataSource es un DataTable
            if (dtg_propiedades.DataSource is DataTable dataTable)
            {
                try
                {
                    DataView dataView = dataTable.DefaultView;

                    // Escapa caracteres especiales en el filtro
                    string filtroEscapado = filtro.Replace("'", "''");

                    // Construye dinámicamente el filtro aplicable a todas las columnas
                    List<string> filtros = new List<string>();
                    foreach (DataColumn columna in dataTable.Columns)
                    {
                        if (columna.DataType == typeof(string)) // Solo columnas de tipo texto
                        {
                            filtros.Add($"{columna.ColumnName} LIKE '%{filtroEscapado}%'");
                        }
                        else if (columna.DataType == typeof(int) || columna.DataType == typeof(decimal)) // Números
                        {
                            if (decimal.TryParse(filtro, out decimal valorNumerico))
                            {
                                filtros.Add($"{columna.ColumnName} = {valorNumerico}");
                            }
                        }
                    }

                    // Une todos los filtros con OR
                    dataView.RowFilter = string.Join(" OR ", filtros);

                    // No es necesario reasignar el DataView
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    MessageBox.Show($"Error al filtrar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El origen de datos no es válido. Asegúrate de vincular un DataTable al DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CleanPropertyData()
        {
            txt_id.Text = "";
            txt_direccion.Text = "";
            txt_ciudad.Text = "";
            txt_estado.Text = "";
            txt_precio.Text = "";
            txt_size.Text = "";
            txt_descripcion.Text = "";




        }

        private void LoadPropertyData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM propiedades";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    dtg_propiedades.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            addProperty();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dtg_propiedades.SelectedRows.Count > 0)
            {
                // Obtener el Id_propiedad de la fila seleccionada

                // Confirmar eliminación
                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar esta propiedad?",
                                                     "Confirmar eliminación",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    eraseProperty();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una propiedad para eliminar.");
            }
        }

        private void frm_propiedades_Load(object sender, EventArgs e)
        {
            LoadPropertyData();

            if (!dtg_propiedades.Columns.Contains("btnEdit"))
            {
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.HeaderText = "Acciones";
                btnEdit.Name = "btnEdit";
                btnEdit.Text = "Editar";
                btnEdit.UseColumnTextForButtonValue = true;
                dtg_propiedades.Columns.Add(btnEdit);
            }

            // Manejar el evento CellClick
            dtg_propiedades.CellClick += dtg_propiedades_CellClick;
        }



        private void btn_search_Click(object sender, EventArgs e)
        {

            // Open frm_buscarcliente as a modal dialog
            using (frm_buscarcliente searchForm = new frm_buscarcliente())
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {
                    // Retrieve the selected Id_cliente after frm_buscarcliente is closed
                    string selectedIdCliente = searchForm.SelectedIdCliente;

                    // Display the selected Id_cliente in a TextBox or use it as needed
                    txt_propietario.Text = selectedIdCliente;
                }
            }

        }

        private void txt_estado_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtg_propiedades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in a valid row and the "btnEdit" column
            if (e.RowIndex >= 0 && e.ColumnIndex == dtg_propiedades.Columns["btnEdit"].Index)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dtg_propiedades.Rows[e.RowIndex];

                // Populate the text boxes and combo boxes with data from the selected row
                txt_id.Text = selectedRow.Cells["id_propiedad"].Value.ToString();
                txt_direccion.Text = selectedRow.Cells["direccion"].Value.ToString();
                txt_ciudad.Text = selectedRow.Cells["ciudad"].Value.ToString();
                txt_estado.Text = selectedRow.Cells["estado"].Value.ToString();
                cb_tipoPropiedad.SelectedItem = selectedRow.Cells["tipo_propiedad"].Value.ToString();
                txt_precio.Text = selectedRow.Cells["precio"].Value.ToString();
                txt_size.Text = selectedRow.Cells["tamano"].Value.ToString();
                cb_habitaciones.SelectedItem = selectedRow.Cells["habitaciones"].Value.ToString();
                cb_bath.SelectedItem = selectedRow.Cells["banos"].Value.ToString();
                cb_estadoP.SelectedItem = selectedRow.Cells["estado_propiedad"].Value.ToString();
                txt_descripcion.Text = selectedRow.Cells["descripcion"].Value.ToString();

                // Optionally, disable fields if necessary (example for txt_direccion and cb_tipoPropiedad)
                txt_propietario.Enabled = false;

            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            editProperty();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarPropiedades(txt_buscar.Text);

        }
    }
}

