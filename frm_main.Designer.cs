namespace ManejadorInmueble
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            btn_home = new Button();
            btn_propiedades = new Button();
            btn_clientes = new Button();
            btn_alquier = new Button();
            btn_agentes = new Button();
            mainpanel = new Panel();
            panel2 = new Panel();
            lbl_usuario = new Label();
            label1 = new Label();
            lbl_minimizar = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(35, 40, 45);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(btn_home);
            flowLayoutPanel1.Controls.Add(btn_propiedades);
            flowLayoutPanel1.Controls.Add(btn_clientes);
            flowLayoutPanel1.Controls.Add(btn_alquier);
            flowLayoutPanel1.Controls.Add(btn_agentes);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(228, 716);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 97);
            panel1.TabIndex = 0;
            // 
            // btn_home
            // 
            btn_home.FlatAppearance.BorderSize = 0;
            btn_home.FlatStyle = FlatStyle.Flat;
            btn_home.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_home.ForeColor = Color.White;
            btn_home.Image = (Image)resources.GetObject("btn_home.Image");
            btn_home.ImageAlign = ContentAlignment.MiddleLeft;
            btn_home.Location = new Point(3, 106);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(225, 45);
            btn_home.TabIndex = 2;
            btn_home.Text = "            Home";
            btn_home.TextAlign = ContentAlignment.MiddleLeft;
            btn_home.UseVisualStyleBackColor = true;
            btn_home.Click += btn_home_Click_1;
            // 
            // btn_propiedades
            // 
            btn_propiedades.FlatAppearance.BorderSize = 0;
            btn_propiedades.FlatStyle = FlatStyle.Flat;
            btn_propiedades.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_propiedades.ForeColor = Color.White;
            btn_propiedades.Image = (Image)resources.GetObject("btn_propiedades.Image");
            btn_propiedades.ImageAlign = ContentAlignment.MiddleLeft;
            btn_propiedades.Location = new Point(3, 157);
            btn_propiedades.Name = "btn_propiedades";
            btn_propiedades.Size = new Size(225, 45);
            btn_propiedades.TabIndex = 3;
            btn_propiedades.Text = "            Propiedades";
            btn_propiedades.TextAlign = ContentAlignment.MiddleLeft;
            btn_propiedades.UseVisualStyleBackColor = true;
            btn_propiedades.Click += btn_propiedades_Click;
            // 
            // btn_clientes
            // 
            btn_clientes.FlatAppearance.BorderSize = 0;
            btn_clientes.FlatStyle = FlatStyle.Flat;
            btn_clientes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_clientes.ForeColor = Color.White;
            btn_clientes.Image = (Image)resources.GetObject("btn_clientes.Image");
            btn_clientes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_clientes.Location = new Point(3, 208);
            btn_clientes.Name = "btn_clientes";
            btn_clientes.Size = new Size(225, 45);
            btn_clientes.TabIndex = 4;
            btn_clientes.Text = "            Clientes";
            btn_clientes.TextAlign = ContentAlignment.MiddleLeft;
            btn_clientes.UseVisualStyleBackColor = true;
            btn_clientes.Click += btn_clientes_Click;
            // 
            // btn_alquier
            // 
            btn_alquier.FlatAppearance.BorderSize = 0;
            btn_alquier.FlatStyle = FlatStyle.Flat;
            btn_alquier.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_alquier.ForeColor = Color.White;
            btn_alquier.Image = (Image)resources.GetObject("btn_alquier.Image");
            btn_alquier.ImageAlign = ContentAlignment.MiddleLeft;
            btn_alquier.Location = new Point(3, 259);
            btn_alquier.Name = "btn_alquier";
            btn_alquier.Size = new Size(225, 45);
            btn_alquier.TabIndex = 5;
            btn_alquier.Text = "            Alquileres";
            btn_alquier.TextAlign = ContentAlignment.MiddleLeft;
            btn_alquier.UseVisualStyleBackColor = true;
            btn_alquier.Click += btn_alquier_Click;
            // 
            // btn_agentes
            // 
            btn_agentes.FlatAppearance.BorderSize = 0;
            btn_agentes.FlatStyle = FlatStyle.Flat;
            btn_agentes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_agentes.ForeColor = Color.FromArgb(224, 224, 224);
            btn_agentes.Image = (Image)resources.GetObject("btn_agentes.Image");
            btn_agentes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_agentes.Location = new Point(3, 310);
            btn_agentes.Name = "btn_agentes";
            btn_agentes.Size = new Size(225, 45);
            btn_agentes.TabIndex = 6;
            btn_agentes.Text = "            Agente";
            btn_agentes.TextAlign = ContentAlignment.MiddleLeft;
            btn_agentes.UseVisualStyleBackColor = true;
            // 
            // mainpanel
            // 
            mainpanel.Location = new Point(226, 33);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1102, 671);
            mainpanel.TabIndex = 1;
            mainpanel.Paint += mainpanel_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 40, 45);
            panel2.Controls.Add(lbl_minimizar);
            panel2.Controls.Add(lbl_usuario);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(226, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1102, 34);
            panel2.TabIndex = 0;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_usuario.ForeColor = Color.White;
            lbl_usuario.Location = new Point(8, 9);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(27, 25);
            lbl_usuario.TabIndex = 2;
            lbl_usuario.Text = "   ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(1072, 0);
            label1.Name = "label1";
            label1.Size = new Size(27, 30);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // lbl_minimizar
            // 
            lbl_minimizar.AutoSize = true;
            lbl_minimizar.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_minimizar.ForeColor = Color.Transparent;
            lbl_minimizar.Location = new Point(1033, -7);
            lbl_minimizar.Name = "lbl_minimizar";
            lbl_minimizar.Size = new Size(33, 45);
            lbl_minimizar.TabIndex = 3;
            lbl_minimizar.Text = "-";
            lbl_minimizar.Click += lbl_minimizar_Click;
            // 
            // frm_main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1329, 716);
            Controls.Add(panel2);
            Controls.Add(mainpanel);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_main";
            Text = "Manejador Inmuebles ";
            Load += frm_main_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button btn_home;
        private Button btn_propiedades;
        private Button btn_clientes;
        private Button btn_alquier;
        private Button btn_agentes;
        private Panel mainpanel;
        private Panel panel2;
        private Label label1;
        private Label lbl_usuario;
        private Label lbl_minimizar;
    }
}