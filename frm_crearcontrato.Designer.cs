namespace ManejadorInmueble
{
    partial class frm_crearcontrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_crearcontrato));
            label1 = new Label();
            txt_propiedad = new TextBox();
            btn_searchCli = new Button();
            label2 = new Label();
            txt_inquilino = new TextBox();
            btn_inquilino = new Button();
            label4 = new Label();
            dtp_fechainicio = new DateTimePicker();
            label5 = new Label();
            dtp_fechavencimiento = new DateTimePicker();
            label6 = new Label();
            txt_monto = new TextBox();
            label7 = new Label();
            cb_frecuenciapago = new ComboBox();
            dtp_fechapago = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            txt_deposito = new TextBox();
            btn_createcontract = new Button();
            label10 = new Label();
            btn_addcontract = new Button();
            txt_route = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 0;
            label1.Text = "Propiedad";
            // 
            // txt_propiedad
            // 
            txt_propiedad.Location = new Point(104, 38);
            txt_propiedad.Name = "txt_propiedad";
            txt_propiedad.Size = new Size(152, 23);
            txt_propiedad.TabIndex = 1;
            // 
            // btn_searchCli
            // 
            btn_searchCli.Image = (Image)resources.GetObject("btn_searchCli.Image");
            btn_searchCli.ImageAlign = ContentAlignment.MiddleLeft;
            btn_searchCli.Location = new Point(260, 31);
            btn_searchCli.Name = "btn_searchCli";
            btn_searchCli.Size = new Size(41, 42);
            btn_searchCli.TabIndex = 2;
            btn_searchCli.UseVisualStyleBackColor = true;
            btn_searchCli.Click += btn_searchCli_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 85);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 3;
            label2.Text = "Inquilino: ";
            // 
            // txt_inquilino
            // 
            txt_inquilino.Location = new Point(90, 83);
            txt_inquilino.Name = "txt_inquilino";
            txt_inquilino.Size = new Size(166, 23);
            txt_inquilino.TabIndex = 4;
            // 
            // btn_inquilino
            // 
            btn_inquilino.Image = (Image)resources.GetObject("btn_inquilino.Image");
            btn_inquilino.ImageAlign = ContentAlignment.MiddleLeft;
            btn_inquilino.Location = new Point(262, 75);
            btn_inquilino.Name = "btn_inquilino";
            btn_inquilino.Size = new Size(39, 37);
            btn_inquilino.TabIndex = 5;
            btn_inquilino.UseVisualStyleBackColor = true;
            btn_inquilino.Click += btn_inquilino_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 134);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 9;
            label4.Text = "Fecha inicio";
            // 
            // dtp_fechainicio
            // 
            dtp_fechainicio.Location = new Point(114, 133);
            dtp_fechainicio.Name = "dtp_fechainicio";
            dtp_fechainicio.Size = new Size(188, 23);
            dtp_fechainicio.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 181);
            label5.Name = "label5";
            label5.Size = new Size(146, 21);
            label5.TabIndex = 11;
            label5.Text = "Fecha vencimiento";
            // 
            // dtp_fechavencimiento
            // 
            dtp_fechavencimiento.Location = new Point(165, 180);
            dtp_fechavencimiento.Name = "dtp_fechavencimiento";
            dtp_fechavencimiento.Size = new Size(154, 23);
            dtp_fechavencimiento.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(352, 40);
            label6.Name = "label6";
            label6.Size = new Size(118, 21);
            label6.TabIndex = 13;
            label6.Text = "Monto a pagar";
            // 
            // txt_monto
            // 
            txt_monto.Location = new Point(468, 42);
            txt_monto.Name = "txt_monto";
            txt_monto.Size = new Size(164, 23);
            txt_monto.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(352, 91);
            label7.Name = "label7";
            label7.Size = new Size(153, 21);
            label7.TabIndex = 15;
            label7.Text = "Frecuencia de pago";
            // 
            // cb_frecuenciapago
            // 
            cb_frecuenciapago.FormattingEnabled = true;
            cb_frecuenciapago.Items.AddRange(new object[] { "Semanal", "Mensual", "Anual" });
            cb_frecuenciapago.Location = new Point(511, 93);
            cb_frecuenciapago.Name = "cb_frecuenciapago";
            cb_frecuenciapago.Size = new Size(121, 23);
            cb_frecuenciapago.TabIndex = 16;
            // 
            // dtp_fechapago
            // 
            dtp_fechapago.Location = new Point(468, 136);
            dtp_fechapago.Name = "dtp_fechapago";
            dtp_fechapago.Size = new Size(164, 23);
            dtp_fechapago.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(352, 133);
            label8.Name = "label8";
            label8.Size = new Size(117, 21);
            label8.TabIndex = 17;
            label8.Text = "Fecha de pago";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(352, 175);
            label9.Name = "label9";
            label9.Size = new Size(130, 21);
            label9.TabIndex = 19;
            label9.Text = "Monto deposito";
            // 
            // txt_deposito
            // 
            txt_deposito.Location = new Point(488, 177);
            txt_deposito.Name = "txt_deposito";
            txt_deposito.Size = new Size(144, 23);
            txt_deposito.TabIndex = 20;
            // 
            // btn_createcontract
            // 
            btn_createcontract.Image = (Image)resources.GetObject("btn_createcontract.Image");
            btn_createcontract.ImageAlign = ContentAlignment.MiddleLeft;
            btn_createcontract.Location = new Point(271, 302);
            btn_createcontract.Name = "btn_createcontract";
            btn_createcontract.Size = new Size(93, 36);
            btn_createcontract.TabIndex = 21;
            btn_createcontract.Text = "        Crear ";
            btn_createcontract.UseVisualStyleBackColor = true;
            btn_createcontract.Click += btn_createcontract_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(378, 243);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.Yes;
            label10.Size = new Size(127, 21);
            label10.TabIndex = 22;
            label10.Text = "Cargar Contrato";
            // 
            // btn_addcontract
            // 
            btn_addcontract.Location = new Point(511, 243);
            btn_addcontract.Name = "btn_addcontract";
            btn_addcontract.Size = new Size(75, 23);
            btn_addcontract.TabIndex = 23;
            btn_addcontract.Text = "Agregar";
            btn_addcontract.UseVisualStyleBackColor = true;
            btn_addcontract.Click += btn_addcontract_Click;
            // 
            // txt_route
            // 
            txt_route.Enabled = false;
            txt_route.Location = new Point(378, 267);
            txt_route.Name = "txt_route";
            txt_route.Size = new Size(208, 23);
            txt_route.TabIndex = 24;
            // 
            // frm_crearcontrato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 410);
            Controls.Add(txt_route);
            Controls.Add(btn_addcontract);
            Controls.Add(label10);
            Controls.Add(btn_createcontract);
            Controls.Add(txt_deposito);
            Controls.Add(label9);
            Controls.Add(dtp_fechapago);
            Controls.Add(label8);
            Controls.Add(cb_frecuenciapago);
            Controls.Add(label7);
            Controls.Add(txt_monto);
            Controls.Add(label6);
            Controls.Add(dtp_fechavencimiento);
            Controls.Add(label5);
            Controls.Add(dtp_fechainicio);
            Controls.Add(label4);
            Controls.Add(btn_inquilino);
            Controls.Add(txt_inquilino);
            Controls.Add(label2);
            Controls.Add(btn_searchCli);
            Controls.Add(txt_propiedad);
            Controls.Add(label1);
            Name = "frm_crearcontrato";
            Text = "frm_crearcontrato";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_propiedad;
        private Button btn_searchCli;
        private Label label2;
        private TextBox txt_inquilino;
        private Button btn_inquilino;
        private Label label4;
        private DateTimePicker dtp_fechainicio;
        private Label label5;
        private DateTimePicker dtp_fechavencimiento;
        private Label label6;
        private TextBox txt_monto;
        private Label label7;
        private ComboBox cb_frecuenciapago;
        private DateTimePicker dtp_fechapago;
        private Label label8;
        private Label label9;
        private TextBox txt_deposito;
        private Button btn_createcontract;
        private Label label10;
        private Button btn_addcontract;
        private TextBox txt_route;
    }
}