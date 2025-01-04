
namespace ManejadorInmueble
{
    partial class frm_propiedades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_propiedades));
            btn_Agregar = new Button();
            btn_editar = new Button();
            btn_borrar = new Button();
            label1 = new Label();
            dtg_propiedades = new DataGridView();
            txt_buscar = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cb_estadoP = new ComboBox();
            label10 = new Label();
            cb_tipoPropiedad = new ComboBox();
            cb_bath = new ComboBox();
            cb_habitaciones = new ComboBox();
            txt_size = new TextBox();
            txt_precio = new TextBox();
            txt_estado = new TextBox();
            txt_ciudad = new TextBox();
            txt_direccion = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label11 = new Label();
            txt_propietario = new TextBox();
            btn_search = new Button();
            label12 = new Label();
            txt_descripcion = new TextBox();
            label13 = new Label();
            txt_id = new TextBox();
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtg_propiedades).BeginInit();
            SuspendLayout();
            // 
            // btn_Agregar
            // 
            btn_Agregar.FlatStyle = FlatStyle.Flat;
            btn_Agregar.ForeColor = SystemColors.ControlText;
            btn_Agregar.Image = (Image)resources.GetObject("btn_Agregar.Image");
            btn_Agregar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Agregar.Location = new Point(888, 57);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(159, 42);
            btn_Agregar.TabIndex = 0;
            btn_Agregar.Text = "            Agregar propiedad";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += button1_Click;
            // 
            // btn_editar
            // 
            btn_editar.FlatStyle = FlatStyle.Flat;
            btn_editar.Image = (Image)resources.GetObject("btn_editar.Image");
            btn_editar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_editar.Location = new Point(888, 132);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(159, 42);
            btn_editar.TabIndex = 1;
            btn_editar.Text = "       Editar propiedad";
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_borrar
            // 
            btn_borrar.FlatStyle = FlatStyle.Flat;
            btn_borrar.Image = (Image)resources.GetObject("btn_borrar.Image");
            btn_borrar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_borrar.Location = new Point(888, 198);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(159, 42);
            btn_borrar.TabIndex = 2;
            btn_borrar.Text = "          Borrar propiedad";
            btn_borrar.UseVisualStyleBackColor = true;
            btn_borrar.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 332);
            label1.Name = "label1";
            label1.Size = new Size(140, 21);
            label1.TabIndex = 3;
            label1.Text = "Buscar Propiedad:";
            // 
            // dtg_propiedades
            // 
            dtg_propiedades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_propiedades.Location = new Point(12, 371);
            dtg_propiedades.Name = "dtg_propiedades";
            dtg_propiedades.Size = new Size(1078, 265);
            dtg_propiedades.TabIndex = 4;
            dtg_propiedades.CellClick += dtg_propiedades_CellClick;
            // 
            // txt_buscar
            // 
            txt_buscar.Location = new Point(240, 330);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(162, 23);
            txt_buscar.TabIndex = 5;
            txt_buscar.TextChanged += txt_buscar_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(64, 78);
            label7.Name = "label7";
            label7.Size = new Size(105, 21);
            label7.TabIndex = 12;
            label7.Text = "Habitaciones";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(64, 117);
            label8.Name = "label8";
            label8.Size = new Size(54, 21);
            label8.TabIndex = 13;
            label8.Text = "Baños";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label9.Location = new Point(64, 153);
            label9.Name = "label9";
            label9.Size = new Size(143, 21);
            label9.TabIndex = 14;
            label9.Text = "Estado propiedad: ";
            // 
            // cb_estadoP
            // 
            cb_estadoP.FormattingEnabled = true;
            cb_estadoP.Items.AddRange(new object[] { "Venta", "Alquiler" });
            cb_estadoP.Location = new Point(203, 151);
            cb_estadoP.Name = "cb_estadoP";
            cb_estadoP.Size = new Size(121, 23);
            cb_estadoP.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label10.Location = new Point(64, 202);
            label10.Name = "label10";
            label10.Size = new Size(140, 21);
            label10.TabIndex = 21;
            label10.Text = "Tipo de propiedad";
            // 
            // cb_tipoPropiedad
            // 
            cb_tipoPropiedad.FormattingEnabled = true;
            cb_tipoPropiedad.Items.AddRange(new object[] { "Casa", "Apartamento", "Solar", "Local" });
            cb_tipoPropiedad.Location = new Point(203, 204);
            cb_tipoPropiedad.Name = "cb_tipoPropiedad";
            cb_tipoPropiedad.Size = new Size(121, 23);
            cb_tipoPropiedad.TabIndex = 22;
            // 
            // cb_bath
            // 
            cb_bath.FormattingEnabled = true;
            cb_bath.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cb_bath.Location = new Point(175, 117);
            cb_bath.Name = "cb_bath";
            cb_bath.Size = new Size(80, 23);
            cb_bath.TabIndex = 23;
            // 
            // cb_habitaciones
            // 
            cb_habitaciones.FormattingEnabled = true;
            cb_habitaciones.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cb_habitaciones.Location = new Point(175, 80);
            cb_habitaciones.Name = "cb_habitaciones";
            cb_habitaciones.Size = new Size(80, 23);
            cb_habitaciones.TabIndex = 24;
            // 
            // txt_size
            // 
            txt_size.Location = new Point(545, 209);
            txt_size.Name = "txt_size";
            txt_size.Size = new Size(186, 23);
            txt_size.TabIndex = 34;
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(545, 170);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(186, 23);
            txt_precio.TabIndex = 33;
            // 
            // txt_estado
            // 
            txt_estado.Location = new Point(545, 134);
            txt_estado.Name = "txt_estado";
            txt_estado.Size = new Size(186, 23);
            txt_estado.TabIndex = 32;
            txt_estado.TextChanged += txt_estado_TextChanged;
            // 
            // txt_ciudad
            // 
            txt_ciudad.Location = new Point(545, 91);
            txt_ciudad.Name = "txt_ciudad";
            txt_ciudad.Size = new Size(186, 23);
            txt_ciudad.TabIndex = 31;
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(545, 52);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(186, 23);
            txt_direccion.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(461, 204);
            label6.Name = "label6";
            label6.Size = new Size(69, 21);
            label6.TabIndex = 29;
            label6.Text = "Tamaño";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(469, 168);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 28;
            label5.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(469, 132);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 27;
            label4.Text = "Estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(469, 89);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 26;
            label3.Text = "Ciudad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(461, 50);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 25;
            label2.Text = "Direccion";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label11.Location = new Point(64, 257);
            label11.Name = "label11";
            label11.Size = new Size(92, 21);
            label11.TabIndex = 35;
            label11.Text = "Propietario";
            // 
            // txt_propietario
            // 
            txt_propietario.Location = new Point(162, 259);
            txt_propietario.Name = "txt_propietario";
            txt_propietario.Size = new Size(110, 23);
            txt_propietario.TabIndex = 36;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(278, 254);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(121, 31);
            btn_search.TabIndex = 37;
            btn_search.Text = "Buscar propietario";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(408, 9);
            label12.Name = "label12";
            label12.Size = new Size(174, 37);
            label12.TabIndex = 38;
            label12.Text = "Propiedades";
            // 
            // txt_descripcion
            // 
            txt_descripcion.Location = new Point(569, 249);
            txt_descripcion.Multiline = true;
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.Size = new Size(162, 89);
            txt_descripcion.TabIndex = 39;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label13.Location = new Point(461, 247);
            label13.Name = "label13";
            label13.Size = new Size(94, 21);
            label13.TabIndex = 40;
            label13.Text = "Descripcion";
            // 
            // txt_id
            // 
            txt_id.Enabled = false;
            txt_id.Location = new Point(175, 52);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(176, 23);
            txt_id.TabIndex = 44;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label15.Location = new Point(64, 50);
            label15.Name = "label15";
            label15.Size = new Size(105, 21);
            label15.TabIndex = 43;
            label15.Text = "ID Propiedad";
            // 
            // frm_propiedades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 671);
            Controls.Add(txt_id);
            Controls.Add(label15);
            Controls.Add(label13);
            Controls.Add(txt_descripcion);
            Controls.Add(label12);
            Controls.Add(btn_search);
            Controls.Add(txt_propietario);
            Controls.Add(label11);
            Controls.Add(txt_size);
            Controls.Add(txt_precio);
            Controls.Add(txt_estado);
            Controls.Add(txt_ciudad);
            Controls.Add(txt_direccion);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cb_habitaciones);
            Controls.Add(cb_bath);
            Controls.Add(cb_tipoPropiedad);
            Controls.Add(label10);
            Controls.Add(cb_estadoP);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txt_buscar);
            Controls.Add(dtg_propiedades);
            Controls.Add(label1);
            Controls.Add(btn_borrar);
            Controls.Add(btn_editar);
            Controls.Add(btn_Agregar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_propiedades";
            Text = "frm_propiedades";
            Load += frm_propiedades_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_propiedades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button btn_Agregar;
        private Button btn_editar;
        private Button btn_borrar;
        private Label label1;
        private DataGridView dtg_propiedades;
        private TextBox txt_buscar;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cb_estadoP;
        private Label label10;
        private ComboBox cb_tipoPropiedad;
        private ComboBox cb_bath;
        private ComboBox cb_habitaciones;
        private TextBox txt_size;
        private TextBox txt_precio;
        private TextBox txt_estado;
        private TextBox txt_ciudad;
        private TextBox txt_direccion;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label11;
        private TextBox txt_propietario;
        private Button btn_search;
        private Label label12;
        private TextBox txt_descripcion;
        private Label label13;
        private TextBox txt_id;
        private Label label15;
    }
}