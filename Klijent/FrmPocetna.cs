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
    public partial class FrmPocetna : Form
    {
        public FrmPocetna()
        {
            InitializeComponent();
        }

        private void PocetnaForma_Load(object sender, EventArgs e)
        {
            this.Text = KontrolerKI.PrikaziUlogovanogKorisnika();
        }

        private void PocetnaForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            KontrolerKI.Kraj();
        }

        private void unosNovogTimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmUnosTima().ShowDialog();
            this.Show();
        }

        private void pretragaTimovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmPretragaTimova().ShowDialog();
            this.Show();
        }

        private void unosNovogMolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmUnosKola().ShowDialog();
            this.Show();

        }

        private void pretragaKolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmPretragaKola().ShowDialog();
            this.Show();
        }

        private void FrmPocetna_Load(object sender, EventArgs e)
        {
            this.Text=KontrolerKI.PrikaziUlogovanogKorisnika();
        }
    }
}
