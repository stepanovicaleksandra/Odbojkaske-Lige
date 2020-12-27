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
    public partial class FrmPrikaziTim : Form
    {
        public FrmPrikaziTim()
        {
            InitializeComponent();
        }

        private void FrmPrikaziTim_Load(object sender, EventArgs e)
        {
            this.Text = "Detalji o timu";
            KontrolerKI.PopuniPoljaTima(txtNaziv, txtMesto, cmbLiga);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.ZapamtiTim(txtMesto, txtNaziv, cmbLiga)) this.Close();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.ObrisiTim()) this.Close();
        }
    }
}
