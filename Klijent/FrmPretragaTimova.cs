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
    public partial class FrmPretragaTimova : Form
    {
        public FrmPretragaTimova()
        {
            InitializeComponent();
        }

        private void FrmPretragaTimova_Load(object sender, EventArgs e)
        {
            KontrolerKI.PretraziTimove(txtNaziv, dataGridView1);
        }

        private void txtNaziv_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                KontrolerKI.PretraziTimove(txtNaziv, dataGridView1);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(KontrolerKI.PrikaziTim(dataGridView1))
            {
                this.Hide();
                new FrmPrikaziTim().ShowDialog();
                this.Show();
            }

            KontrolerKI.PretraziTimove(txtNaziv, dataGridView1);
        }
    }
}
