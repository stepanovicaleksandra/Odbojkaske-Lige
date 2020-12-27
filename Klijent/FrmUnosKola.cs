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
    public partial class FrmUnosKola : Form
    {
        public FrmUnosKola()
        {
            InitializeComponent();
        }

        private void btnKreirajKolo_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.KreirajKolo(txtSifra, dataGridView1))
            {

                KontrolerKI.PopuniCmbLiga(cmbLiga);
                KontrolerKI.popuniCmbHala(cmbHala);
                KontrolerKI.PopuniDelegata(txtDelegat);
                KontrolerKI.popuniCmbStatus(cmbStatus);
                gbKolo.Enabled = true;
                btnKreirajKolo.Enabled = false;
                txtSifra.Enabled = false;


            }
        }

        private void cmbLiga_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDomacin.Enabled = true;
            cmbGost.Enabled = true;
            KontrolerKI.popuniCmbDomacin(cmbDomacin, cmbLiga, cmbGost);
            KontrolerKI.popuniCmbGost(cmbGost, cmbDomacin, cmbLiga);
            KontrolerKI.OcistiGrid(dataGridView1);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            KontrolerKI.DodajMec(cmbDomacin, cmbGost, txtDatumVreme, cmbHala, cmbStatus, dtpDatumDo,dtpDatumOd, cmbLiga);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            KontrolerKI.ObrisiMec(dataGridView1);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
           if(KontrolerKI.SacuvajKolo(cmbLiga, txtNaziv, dtpDatumOd, dtpDatumDo)) this.Close();
        }

        private void FrmUnosKola_Load(object sender, EventArgs e)
        {

        }
    }
}
