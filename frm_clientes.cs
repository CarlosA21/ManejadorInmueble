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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ManejadorInmueble
{
    public partial class frm_clientes : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=\"E:\\SELLING PROJECTS\\MANEJADORINMUEBLE\\MAN_INMDB.MDF\";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public long cedula = 0;
        string nombre = string.Empty;
        string apellido = string.Empty;
        long telefono = 0;
        string correoElectronico = string.Empty;

        private bool TryGetLongFromTextBox(TextBox textBox, out long result, string errorMessage)
        {
            if (long.TryParse(textBox.Text.Trim(), out result))
                return true;

            MessageBox.Show(errorMessage);
            result = 0;
            return false;
        }
        private void addClient()
        {
            string tipocli = cb_tipocliente.SelectedItem.ToString();

            try
            {
                // Consulta SQL para insertar los datos
                string query = @"
                        INSERT INTO cliente (Id_cliente, nombre, apellido, telefono, email, tipo_cliente)
                        VALUES (@Cedula, @Nombre, @Apellido, @Telefono, @Email, @TipoCliente)";

                // Usar using para asegurar la liberación de recursos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    // Parámetros para prevenir inyección de SQL
                    command.Parameters.AddWithValue("@Cedula", cedula);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Email", correoElectronico);
                    command.Parameters.AddWithValue("@TipoCliente", tipocli);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show($"{rowsAffected} Cliente agregado exitosamente.");
                    LoadClientData();
                    cleanData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
        private void editClient()
        {
            string tipocli = cb_tipocliente.SelectedItem.ToString();

            // Actualizar en la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string updateQuery = "UPDATE cliente SET nombre = @nombre, apellido = @apellido, telefono = @telefono, email = @correo, tipo_cliente = @tipo_cliente WHERE Id_cliente = @Id_cliente";
                    SqlCommand command = new SqlCommand(updateQuery, connection);

                    command.Parameters.AddWithValue("@Id_cliente", cedula);  // Supone que cedula se usa como Id_cliente
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@correo", correoElectronico);
                    command.Parameters.AddWithValue("@tipo_cliente", tipocli);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cliente actualizado exitosamente.");
                        // Recargar el DataGridView
                        LoadClientData();
                        cleanData();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el cliente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el cliente: " + ex.Message);
                }
            }
        }

        private void eraseClient()
        {
            string idCliente = dtg_cliente.SelectedRows[0].Cells["Id_cliente"].Value.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM cliente WHERE Id_cliente = @Id_cliente";
                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@Id_cliente", idCliente);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Cliente eliminado exitosamente.");

                    // Actualizar el DataGridView
                    LoadClientData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
                }
            }
        }


        bool TryGetNonEmptyStringFromTextBox(TextBox textBox, out string result, string errorMessage)
        {
            result = textBox.Text.Trim();
            if (!string.IsNullOrEmpty(result))
                return true;

            MessageBox.Show(errorMessage);
            result = string.Empty;
            return false;
        }

        bool TryGetValidEmailFromTextBox(TextBox textBox, out string result, string errorMessage)
        {
            result = textBox.Text.Trim();
            if (!string.IsNullOrEmpty(result) && IsValidEmail(result))
                return true;

            MessageBox.Show(errorMessage);
            result = string.Empty;
            return false;
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void cleanData()
        {
            txt_cedula.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_telefono.Text = "";
            txt_correo.Text = "";
        }
        private void LoadClientData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM cliente";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    dtg_cliente.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

        public frm_clientes()
        {
            InitializeComponent();
        }
        private void FiltrarClientes(string filtro)
        {
            // Verifica si el DataSource es un DataTable
            if (dtg_cliente.DataSource is DataTable dataTable)
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
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            // Limitar a 11 dígitos
            if (txt_cedula.Text.Length > 11)
            {
                txt_cedula.Text = txt_cedula.Text.Substring(0, 11);
                txt_cedula.SelectionStart = txt_cedula.Text.Length; // Mover el cursor al final
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            // Variables

            // Validar y asignar valores
            if (!TryGetLongFromTextBox(txt_cedula, out cedula, "Por favor, ingrese un número de cédula válido.") ||
                !TryGetNonEmptyStringFromTextBox(txt_nombre, out nombre, "Por favor, ingrese un nombre válido.") ||
                !TryGetNonEmptyStringFromTextBox(txt_apellido, out apellido, "Por favor, ingrese una edad válida.") ||
                !TryGetValidEmailFromTextBox(txt_correo, out correoElectronico, "Por favor, ingrese un correo electrónico válido.") ||
                !TryGetLongFromTextBox(txt_telefono, out telefono, "Por favor, ingrese un número telefono válido."))
            {
                // Si alguna validación falla, se detiene el flujo
                return;
            }
            else
            {
                addClient();
            }


        }

        private void frm_clientes_Load(object sender, EventArgs e)
        {
            LoadClientData();

            if (!dtg_cliente.Columns.Contains("btnEdit"))
            {
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.HeaderText = "Acciones";
                btnEdit.Name = "btnEdit";
                btnEdit.Text = "Editar";
                btnEdit.UseColumnTextForButtonValue = true;
                dtg_cliente.Columns.Add(btnEdit);
            }

            // Manejar el evento CellClick
            dtg_cliente.CellClick += dtg_cliente_CellClick;
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (dtg_cliente.SelectedRows.Count > 0)
            {
                // Obtener el Id_cliente de la fila seleccionada

                // Confirmar eliminación
                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?",
                                                     "Confirmar eliminación",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    eraseClient();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
            }
        }

        private void txt_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y control de retroceso (Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtg_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dtg_cliente.Columns["btnEdit"].Index)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dtg_cliente.Rows[e.RowIndex];

                // Pasar los valores de la fila a los TextBox
                txt_cedula.Text = selectedRow.Cells["Id_cliente"].Value.ToString(); // Supone que Id_cliente es la columna para cédula
                txt_nombre.Text = selectedRow.Cells["nombre"].Value.ToString();
                txt_apellido.Text = selectedRow.Cells["apellido"].Value.ToString();
                txt_telefono.Text = selectedRow.Cells["telefono"].Value.ToString();
                txt_correo.Text = selectedRow.Cells["email"].Value.ToString();
                cb_tipocliente.SelectedItem = selectedRow.Cells["tipo_cliente"].Value.ToString();

                // Deshabilitar txt_cedula y cb_tipocliente
                txt_cedula.Enabled = false;
                cb_tipocliente.Enabled = false;
            }
        }

        private void btn_ediar_Click(object sender, EventArgs e)
        {
            // Validar y asignar valores
            if (!TryGetLongFromTextBox(txt_cedula, out cedula, "Por favor, ingrese un número de cédula válido.") ||
                !TryGetNonEmptyStringFromTextBox(txt_nombre, out nombre, "Por favor, ingrese un nombre válido.") ||
                !TryGetNonEmptyStringFromTextBox(txt_apellido, out apellido, "Por favor, ingrese un apellido válido.") ||
                !TryGetValidEmailFromTextBox(txt_correo, out correoElectronico, "Por favor, ingrese un correo electrónico válido.") ||
                !TryGetLongFromTextBox(txt_telefono, out telefono, "Por favor, ingrese un número de teléfono válido."))
            {

                return;
            }
            else
            {
                editClient();
            }


        }

        private void txt_bCliente_TextChanged(object sender, EventArgs e)
        {
            FiltrarClientes(txt_bCliente.Text);
        }
    }
}

