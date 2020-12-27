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
    public partial class FrmUnosTima : Form
    {
        public FrmUnosTima()
        {
            InitializeComponent();
        }

        private void FromUnosTima_Load(object sender, EventArgs e)
        {
            this.Text = "Unos novog tima";
        }

        private void btnKreirajTim_Click(object sender, EventArgs e)
        {
           if(KontrolerKI.KreirajTim(txtId, txtMesto, txtNaziv, cmbLiga, btnKreirajTim, btnZapamtiTim))
            {
                MessageBox.Show("Sistem je kreirao nov tim!");
                KontrolerKI.PopuniCmbLiga(cmbLiga);
            }
        }

        private void btnZapamtiTim_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.ZapamtiTim(txtMesto, txtNaziv, cmbLiga)) this.Close();
        }
    }
}
