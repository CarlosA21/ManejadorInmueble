namespace ManejadorInmueble
{
    partial class frm_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            label1 = new Label();
            label3 = new Label();
            txt_user = new TextBox();
            txt_pass = new TextBox();
            btn_acceder = new Button();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 9);
            label1.Name = "label1";
            label1.Size = new Size(251, 32);
            label1.TabIndex = 0;
            label1.Text = "Manejador Inmuebles";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(140, 155);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            label3.Click += label3_Click;
            // 
            // txt_user
            // 
            txt_user.Location = new Point(116, 120);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(158, 23);
            txt_user.TabIndex = 3;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(116, 183);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(158, 23);
            txt_pass.TabIndex = 4;
            // 
            // btn_acceder
            // 
            btn_acceder.Location = new Point(140, 248);
            btn_acceder.Name = "btn_acceder";
            btn_acceder.Size = new Size(97, 23);
            btn_acceder.TabIndex = 5;
            btn_acceder.Text = "Acceder";
            btn_acceder.UseVisualStyleBackColor = true;
            btn_acceder.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(162, 86);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(140, 92);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 6;
            label4.Text = "USUARIO";
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(410, 381);
            Controls.Add(label4);
            Controls.Add(btn_acceder);
            Controls.Add(txt_pass);
            Controls.Add(txt_user);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frm_login";
            Text = "Manejador Inmueble";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox txt_user;
        private TextBox txt_pass;
        private Button btn_acceder;
        private Label label2;
        private Label label4;
    }
}
