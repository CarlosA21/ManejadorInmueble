namespace ManejadorInmueble
{
    partial class frm_buscarcliente
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
            label1 = new Label();
            dtg_prop = new DataGridView();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtg_prop).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(206, 37);
            label1.Name = "label1";
            label1.Size = new Size(178, 25);
            label1.TabIndex = 0;
            label1.Text = "Buscar propietario: ";
            // 
            // dtg_prop
            // 
            dtg_prop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_prop.Location = new Point(12, 74);
            dtg_prop.Name = "dtg_prop";
            dtg_prop.Size = new Size(776, 309);
            dtg_prop.TabIndex = 1;
            dtg_prop.CellContentClick += dtg_prop_CellContentClick;
            dtg_prop.CellDoubleClick += dtg_prop_CellDoubleClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(390, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // frm_buscarcliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 420);
            Controls.Add(textBox1);
            Controls.Add(dtg_prop);
            Controls.Add(label1);
            Name = "frm_buscarcliente";
            Text = "frm_buscarcliente";
            Load += frm_buscarcliente_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_prop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtg_prop;
        private TextBox textBox1;
    }
}