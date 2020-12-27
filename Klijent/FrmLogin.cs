using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class FormaKlijent : Form
    {
       
        public FormaKlijent()
        {
            InitializeComponent();
        }

        private void FormaKlijent_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.PoveziSeNaServer())
            {
                if(KontrolerKI.Login(txtKorIme, txtSifra))
                {
                    this.Hide();
                    new FrmPocetna().ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Povezivanje na server nije uspelo !");
            }
        }
    }
}
