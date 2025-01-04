namespace ManejadorInmueble
{
    partial class frm_alquiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_alquiler));
            label1 = new Label();
            btn_crearalquiler = new Button();
            label2 = new Label();
            dtg_proxAlq = new DataGridView();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtg_proxAlq).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(400, 9);
            label1.Name = "label1";
            label1.Size = new Size(108, 30);
            label1.TabIndex = 0;
            label1.Text = "Alquileres";
            // 
            // btn_crearalquiler
            // 
            btn_crearalquiler.Image = (Image)resources.GetObject("btn_crearalquiler.Image");
            btn_crearalquiler.ImageAlign = ContentAlignment.MiddleLeft;
            btn_crearalquiler.Location = new Point(247, 536);
            btn_crearalquiler.Name = "btn_crearalquiler";
            btn_crearalquiler.Size = new Size(181, 53);
            btn_crearalquiler.TabIndex = 1;
            btn_crearalquiler.Text = "            Crear Contrato";
            btn_crearalquiler.TextAlign = ContentAlignment.MiddleLeft;
            btn_crearalquiler.UseVisualStyleBackColor = true;
            btn_crearalquiler.Click += btn_crearalquiler_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(136, 21);
            label2.TabIndex = 2;
            label2.Text = "Contratos activos";
            label2.Click += label2_Click;
            // 
            // dtg_proxAlq
            // 
            dtg_proxAlq.AllowUserToAddRows = false;
            dtg_proxAlq.BorderStyle = BorderStyle.None;
            dtg_proxAlq.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_proxAlq.Location = new Point(12, 101);
            dtg_proxAlq.Name = "dtg_proxAlq";
            dtg_proxAlq.ReadOnly = true;
            dtg_proxAlq.Size = new Size(956, 429);
            dtg_proxAlq.TabIndex = 3;
            dtg_proxAlq.CellClick += dtg_proxAlq_CellClick;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(500, 536);
            button1.Name = "button1";
            button1.Size = new Size(181, 53);
            button1.TabIndex = 7;
            button1.Text = "            Buscar Contrato";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(330, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 23);
            textBox1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(258, 65);
            label3.Name = "label3";
            label3.Size = new Size(121, 21);
            label3.TabIndex = 9;
            label3.Text = "Buscar activos: ";
            // 
            // frm_alquiler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 622);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(dtg_proxAlq);
            Controls.Add(label2);
            Controls.Add(btn_crearalquiler);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_alquiler";
            Text = "frm_alquiler";
            Load += frm_alquiler_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_proxAlq).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_crearalquiler;
        private Label label2;
        private DataGridView dtg_proxAlq;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
    }
}