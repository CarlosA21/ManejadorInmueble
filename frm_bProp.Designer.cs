namespace ManejadorInmueble
{
    partial class frm_bProp
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
            dtg_inquilino = new DataGridView();
            label1 = new Label();
            txt_buscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtg_inquilino).BeginInit();
            SuspendLayout();
            // 
            // dtg_inquilino
            // 
            dtg_inquilino.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_inquilino.Location = new Point(12, 66);
            dtg_inquilino.Name = "dtg_inquilino";
            dtg_inquilino.Size = new Size(724, 255);
            dtg_inquilino.TabIndex = 0;
            dtg_inquilino.CellContentDoubleClick += dtg_inquilino_CellContentDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(174, 18);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 1;
            label1.Text = "Buscar Propiedad";
            // 
            // txt_buscar
            // 
            txt_buscar.Location = new Point(343, 23);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(169, 23);
            txt_buscar.TabIndex = 2;
            // 
            // frm_bProp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 351);
            Controls.Add(txt_buscar);
            Controls.Add(label1);
            Controls.Add(dtg_inquilino);
            Name = "frm_bProp";
            Text = "frm_bProp";
            Load += frm_bProp_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_inquilino).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_inquilino;
        private Label label1;
        private TextBox txt_buscar;
    }
}