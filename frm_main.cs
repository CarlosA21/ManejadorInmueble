using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorInmueble
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {

        }

        private void btn_propiedades_Click(object sender, EventArgs e)
        {
            loadform(new frm_propiedades());
        }

        private void btn_home_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            loadform(new frm_clientes());
        }
    }
}
