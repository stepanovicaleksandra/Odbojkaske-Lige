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
    public partial class FrmPrikaziKolo : Form
    {
        public FrmPrikaziKolo()
        {
            InitializeComponent();
        }

        private void FrmPrikaziKolo_Load(object sender, EventArgs e)
        {
            KontrolerKI.PopuniPoljaKola(cmbLiga,dtpDatumDo,dtpDatumOd,txtNaziv,txtDelegat, dataGridView1);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
           if(KontrolerKI.IzaberiMec(dataGridView1)) new FrmPrikaziMec(dtpDatumDo,dtpDatumOd,cmbLiga).ShowDialog();
            dataGridView1.Refresh();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.IzmeniKolo(cmbLiga, dtpDatumDo, txtNaziv, dtpDatumOd)) this.Close();

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            KontrolerKI.ObrisiMec(dataGridView1);
        }


        private void btnDodajMec_Click(object sender, EventArgs e)
        {
            new FrmDodajMec(dtpDatumDo,dtpDatumOd, cmbLiga).ShowDialog();
             
        }

  
    }
}
