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
    public partial class FrmPretragaKola : Form
    {
        public FrmPretragaKola()
        {
            InitializeComponent();
        }

        private void FrmPretragaKola_Load(object sender, EventArgs e)
        {
            KontrolerKI.PopuniCmbLiga(cmbLiga);
        }

        private void cmbLiga_SelectedIndexChanged(object sender, EventArgs e)
        {
            KontrolerKI.PretraziKola(cmbLiga, dataGridView1);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (KontrolerKI.IzaberiKolo(dataGridView1)) new FrmPrikaziKolo().ShowDialog();
        }
    }
}
