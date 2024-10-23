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
            btn_borrar = new Button();
            btn_ediar = new Button();
            btn_Agregar = new Button();
            dataGridView1 = new DataGridView();
            btn_buscar = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.Location = new Point(147, 214);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(186, 23);
            textBox6.TabIndex = 44;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(173, 175);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(186, 23);
            textBox5.TabIndex = 43;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(110, 139);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(186, 23);
            textBox4.TabIndex = 42;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(110, 96);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 23);
            textBox3.TabIndex = 41;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 23);
            textBox2.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(26, 212);
            label6.Name = "label6";
            label6.Size = new Size(115, 21);
            label6.TabIndex = 39;
            label6.Text = "Fecha Registro";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(26, 173);
            label5.Name = "label5";
            label5.Size = new Size(141, 21);
            label5.TabIndex = 38;
            label5.Text = "Correo electronico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(34, 137);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 37;
            label4.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(34, 94);
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
            label2.Location = new Point(26, 62);
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
            btn_borrar.Location = new Point(733, 184);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(159, 42);
            btn_borrar.TabIndex = 47;
            btn_borrar.Text = "          Borrar propiedad";
            btn_borrar.UseVisualStyleBackColor = true;
            // 
            // btn_ediar
            // 
            btn_ediar.FlatStyle = FlatStyle.Flat;
            btn_ediar.Image = (Image)resources.GetObject("btn_ediar.Image");
            btn_ediar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ediar.Location = new Point(733, 125);
            btn_ediar.Name = "btn_ediar";
            btn_ediar.Size = new Size(159, 42);
            btn_ediar.TabIndex = 46;
            btn_ediar.Text = "       Editar propiedad";
            btn_ediar.UseVisualStyleBackColor = true;
            // 
            // btn_Agregar
            // 
            btn_Agregar.FlatStyle = FlatStyle.Flat;
            btn_Agregar.ForeColor = SystemColors.ControlText;
            btn_Agregar.Image = (Image)resources.GetObject("btn_Agregar.Image");
            btn_Agregar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Agregar.Location = new Point(733, 62);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(159, 42);
            btn_Agregar.TabIndex = 45;
            btn_Agregar.Text = "            Agregar propiedad";
            btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 300);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(972, 327);
            dataGridView1.TabIndex = 48;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(592, 276);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(127, 23);
            btn_buscar.TabIndex = 51;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(424, 276);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 23);
            textBox1.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(301, 276);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 49;
            label1.Text = "Buscar Cliente:";
            // 
            // frm_clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 661);
            Controls.Add(btn_buscar);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btn_borrar);
            Controls.Add(btn_ediar);
            Controls.Add(btn_Agregar);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_clientes";
            Text = "frm_clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Button btn_borrar;
        private Button btn_ediar;
        private Button btn_Agregar;
        private DataGridView dataGridView1;
        private Button btn_buscar;
        private TextBox textBox1;
        private Label label1;
    }
}