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
            btn_ediar = new Button();
            btn_borrar = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            btn_buscar = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBox1 = new ComboBox();
            label10 = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label11 = new Label();
            textBox7 = new TextBox();
            button2 = new Button();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_Agregar
            // 
            btn_Agregar.FlatStyle = FlatStyle.Flat;
            btn_Agregar.ForeColor = SystemColors.ControlText;
            btn_Agregar.Image = (Image)resources.GetObject("btn_Agregar.Image");
            btn_Agregar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Agregar.Location = new Point(744, 46);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(159, 42);
            btn_Agregar.TabIndex = 0;
            btn_Agregar.Text = "            Agregar propiedad";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += button1_Click;
            // 
            // btn_ediar
            // 
            btn_ediar.FlatStyle = FlatStyle.Flat;
            btn_ediar.Image = (Image)resources.GetObject("btn_ediar.Image");
            btn_ediar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ediar.Location = new Point(744, 109);
            btn_ediar.Name = "btn_ediar";
            btn_ediar.Size = new Size(159, 42);
            btn_ediar.TabIndex = 1;
            btn_ediar.Text = "       Editar propiedad";
            btn_ediar.UseVisualStyleBackColor = true;
            // 
            // btn_borrar
            // 
            btn_borrar.FlatStyle = FlatStyle.Flat;
            btn_borrar.Image = (Image)resources.GetObject("btn_borrar.Image");
            btn_borrar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_borrar.Location = new Point(744, 168);
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
            label1.Location = new Point(497, 273);
            label1.Name = "label1";
            label1.Size = new Size(140, 21);
            label1.TabIndex = 3;
            label1.Text = "Buscar Propiedad:";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 309);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(972, 327);
            dataGridView1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(643, 271);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 23);
            textBox1.TabIndex = 5;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(811, 271);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(127, 23);
            btn_buscar.TabIndex = 6;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(26, 46);
            label7.Name = "label7";
            label7.Size = new Size(105, 21);
            label7.TabIndex = 12;
            label7.Text = "Habitaciones";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(26, 85);
            label8.Name = "label8";
            label8.Size = new Size(54, 21);
            label8.TabIndex = 13;
            label8.Text = "Baños";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label9.Location = new Point(26, 121);
            label9.Name = "label9";
            label9.Size = new Size(143, 21);
            label9.TabIndex = 14;
            label9.Text = "Estado propiedad: ";
            label9.Click += label9_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(165, 119);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label10.Location = new Point(26, 170);
            label10.Name = "label10";
            label10.Size = new Size(140, 21);
            label10.TabIndex = 21;
            label10.Text = "Tipo de propiedad";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(165, 172);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 22;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox3.Location = new Point(137, 85);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(80, 23);
            comboBox3.TabIndex = 23;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox4.Location = new Point(137, 48);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(80, 23);
            comboBox4.TabIndex = 24;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(448, 207);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(186, 23);
            textBox6.TabIndex = 34;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(448, 168);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(186, 23);
            textBox5.TabIndex = 33;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(448, 132);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(186, 23);
            textBox4.TabIndex = 32;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(448, 89);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 23);
            textBox3.TabIndex = 31;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(448, 57);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 23);
            textBox2.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(364, 202);
            label6.Name = "label6";
            label6.Size = new Size(69, 21);
            label6.TabIndex = 29;
            label6.Text = "Tamaño";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(372, 166);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 28;
            label5.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(372, 130);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 27;
            label4.Text = "Estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(372, 87);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 26;
            label3.Text = "Ciudad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(364, 55);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 25;
            label2.Text = "Direccion";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label11.Location = new Point(26, 225);
            label11.Name = "label11";
            label11.Size = new Size(92, 21);
            label11.TabIndex = 35;
            label11.Text = "Propietario";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(124, 227);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(110, 23);
            textBox7.TabIndex = 36;
            // 
            // button2
            // 
            button2.Location = new Point(240, 222);
            button2.Name = "button2";
            button2.Size = new Size(121, 31);
            button2.TabIndex = 37;
            button2.Text = "Buscar propietario";
            button2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(324, 8);
            label12.Name = "label12";
            label12.Size = new Size(174, 37);
            label12.TabIndex = 38;
            label12.Text = "Propiedades";
            label12.Click += label12_Click;
            // 
            // frm_propiedades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 661);
            Controls.Add(label12);
            Controls.Add(button2);
            Controls.Add(textBox7);
            Controls.Add(label11);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(label10);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btn_buscar);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(btn_borrar);
            Controls.Add(btn_ediar);
            Controls.Add(btn_Agregar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_propiedades";
            Text = "frm_propiedades";
            Load += frm_propiedades_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Agregar;
        private Button btn_ediar;
        private Button btn_borrar;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button btn_buscar;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox comboBox1;
        private Label label10;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label11;
        private TextBox textBox7;
        private Button button2;
        private Label label12;
    }
}