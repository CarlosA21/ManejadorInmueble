namespace ManejadorInmueble
{
    partial class frm_buscInq
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
            textBox1 = new TextBox();
            dtg_inq = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtg_inq).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(357, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 23);
            textBox1.TabIndex = 5;
            // 
            // dtg_inq
            // 
            dtg_inq.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_inq.Location = new Point(12, 89);
            dtg_inq.Name = "dtg_inq";
            dtg_inq.Size = new Size(776, 309);
            dtg_inq.TabIndex = 4;
            dtg_inq.CellContentDoubleClick += dtg_inq_CellContentDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(206, 52);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 3;
            label1.Text = "Buscar inquilino: ";
            // 
            // frm_buscInq
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(dtg_inq);
            Controls.Add(label1);
            Name = "frm_buscInq";
            Text = "frm_buscInq";
            Load += frm_buscInq_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_inq).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DataGridView dtg_inq;
        private Label label1;
    }
}