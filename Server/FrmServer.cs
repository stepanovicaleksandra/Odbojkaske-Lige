using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        Server s;
        public FrmServer()
        {
            InitializeComponent();
        }

        private void FormaServer_Load(object sender, EventArgs e)
        {
            
            this.Text = "Server";
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            s = new Server();
            if (s.pokreniServer())
            {
                lblStatus.Text = "Server je pokrenut!";
                lblStatus.ForeColor = Color.Green;
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
            }
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            if (Server.listaTokova.Count > 0)
            {
                MessageBox.Show("Server ne moze biti ugasen!\nPostoje korisnici na sistemu!");
                return;
            }

            if (s.zaustaviServer())
            {
                lblStatus.Text = "Server nije pokrenut!";
                lblStatus.ForeColor = Color.Red;
                btnPokreni.Enabled = true;
                btnZaustavi.Enabled = false;
            }

        }
    }
}
