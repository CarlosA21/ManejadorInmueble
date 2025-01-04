
namespace ManejadorInmueble
{
    partial class frm_clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_clientes));
            txt_correo = new TextBox();
            txt_telefono = new TextBox();
            txt_apellido = new TextBox();
            txt_nombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btn_borrar = new Button();
            btn_ediar = new Button();
            btn_Agregar = new Button();
            dtg_cliente = new DataGridView();
            txt_bCliente = new TextBox();
            label1 = new Label();
            txt_cedula = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            cb_tipocliente = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtg_cliente).BeginInit();
            SuspendLayout();
            // 
            // txt_correo
            // 
            txt_correo.Location = new Point(169, 207);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(186, 23);
            txt_correo.TabIndex = 43;
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(121, 159);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(186, 23);
            txt_telefono.TabIndex = 42;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(121, 117);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(186, 23);
            txt_apellido.TabIndex = 41;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(121, 85);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(186, 23);
            txt_nombre.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(12, 205);
            label5.Name = "label5";
            label5.Size = new Size(141, 21);
            label5.TabIndex = 38;
            label5.Text = "Correo electronico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(34, 157);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 37;
            label4.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(37, 115);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 36;
            label3.Text = "Apellido";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(37, 83);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 35;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // btn_borrar
            // 
            btn_borrar.FlatStyle = FlatStyle.Flat;
            btn_borrar.Image = (Image)resources.GetObject("btn_borrar.Image");
            btn_borrar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_borrar.Location = new Point(845, 184);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(159, 42);
            btn_borrar.TabIndex = 47;
            btn_borrar.Text = "          Borrar Cliente";
            btn_borrar.UseVisualStyleBackColor = true;
            btn_borrar.Click += btn_borrar_Click;
            // 
            // btn_ediar
            // 
            btn_ediar.FlatStyle = FlatStyle.Flat;
            btn_ediar.Image = (Image)resources.GetObject("btn_ediar.Image");
            btn_ediar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ediar.Location = new Point(845, 125);
            btn_ediar.Name = "btn_ediar";
            btn_ediar.Size = new Size(159, 42);
            btn_ediar.TabIndex = 46;
            btn_ediar.Text = "       Actualizar Cliente";
            btn_ediar.UseVisualStyleBackColor = true;
            btn_ediar.Click += btn_ediar_Click;
            // 
            // btn_Agregar
            // 
            btn_Agregar.FlatStyle = FlatStyle.Flat;
            btn_Agregar.ForeColor = SystemColors.ControlText;
            btn_Agregar.Image = (Image)resources.GetObject("btn_Agregar.Image");
            btn_Agregar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Agregar.Location = new Point(845, 62);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(159, 42);
            btn_Agregar.TabIndex = 45;
            btn_Agregar.Text = "            Agregar Cliente";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // dtg_cliente
            // 
            dtg_cliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_cliente.Location = new Point(12, 322);
            dtg_cliente.Name = "dtg_cliente";
            dtg_cliente.Size = new Size(1078, 327);
            dtg_cliente.TabIndex = 48;
            dtg_cliente.CellClick += dtg_cliente_CellClick;
            // 
            // txt_bCliente
            // 
            txt_bCliente.Location = new Point(462, 286);
            txt_bCliente.Name = "txt_bCliente";
            txt_bCliente.Size = new Size(162, 23);
            txt_bCliente.TabIndex = 50;
            txt_bCliente.TextChanged += txt_bCliente_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(339, 288);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 49;
            label1.Text = "Buscar Cliente:";
            // 
            // txt_cedula
            // 
            txt_cedula.Location = new Point(121, 47);
            txt_cedula.Name = "txt_cedula";
            txt_cedula.Size = new Size(186, 23);
            txt_cedula.TabIndex = 53;
            txt_cedula.TextChanged += textBox7_TextChanged;
            txt_cedula.KeyPress += txt_cedula_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(37, 47);
            label7.Name = "label7";
            label7.Size = new Size(60, 21);
            label7.TabIndex = 52;
            label7.Text = "Cedula";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(437, 9);
            label8.Name = "label8";
            label8.Size = new Size(103, 32);
            label8.TabIndex = 54;
            label8.Text = "Clientes";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(407, 62);
            label6.Name = "label6";
            label6.Size = new Size(115, 21);
            label6.TabIndex = 55;
            label6.Text = "Tipo de cliente";
            // 
            // cb_tipocliente
            // 
            cb_tipocliente.FormattingEnabled = true;
            cb_tipocliente.Items.AddRange(new object[] { "Propietario", "Inquilino" });
            cb_tipocliente.Location = new Point(528, 64);
            cb_tipocliente.Name = "cb_tipocliente";
            cb_tipocliente.Size = new Size(121, 23);
            cb_tipocliente.TabIndex = 56;
            // 
            // frm_clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 671);
            Controls.Add(cb_tipocliente);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(txt_cedula);
            Controls.Add(label7);
            Controls.Add(txt_bCliente);
            Controls.Add(label1);
            Controls.Add(dtg_cliente);
            Controls.Add(btn_borrar);
            Controls.Add(btn_ediar);
            Controls.Add(btn_Agregar);
            Controls.Add(txt_correo);
            Controls.Add(txt_telefono);
            Controls.Add(txt_apellido);
            Controls.Add(txt_nombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_clientes";
            Text = "frm_clientes";
            Load += frm_clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_cliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private TextBox txt_correo;
        private TextBox txt_telefono;
        private TextBox txt_apellido;
        private TextBox txt_nombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btn_borrar;
        private Button btn_ediar;
        private Button btn_Agregar;
        private DataGridView dtg_cliente;
        private Button btn_buscar;
        private TextBox txt_bCliente;
        private Label label1;
        private TextBox txt_cedula;
        private Label label7;
        private Label label8;
        private Label label6;
        private ComboBox cb_tipocliente;
    }
}