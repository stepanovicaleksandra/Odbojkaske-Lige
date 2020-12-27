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
    public partial class FrmDodajMec : Form
    {
        DateTimePicker dtpDatumDo;
        DateTimePicker dtpDatumOd;
        ComboBox cmbLiga;

        public FrmDodajMec(DateTimePicker dtpDatumDo, DateTimePicker dtpDatumOd, ComboBox cmbLiga)
        {
            InitializeComponent();
            this.dtpDatumDo = dtpDatumDo;
            this.dtpDatumOd = dtpDatumOd;
            this.cmbLiga = cmbLiga;
        }

        private void FrmDodajMec_Load(object sender, EventArgs e)
        {
            KontrolerKI.popuniCmbHala(cmbHala);
            KontrolerKI.popuniCmbDomacin(cmbDomacin,cmbLiga,cmbGost);
            KontrolerKI.popuniCmbGost(cmbGost, cmbDomacin, cmbLiga);
            KontrolerKI.popuniCmbStatus(cmbStatus);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (KontrolerKI.DodajDodatniMec(cmbDomacin, cmbGost, txtDatumVreme, cmbHala, cmbStatus, dtpDatumDo, dtpDatumOd)) this.Close();
        }
    }
}
