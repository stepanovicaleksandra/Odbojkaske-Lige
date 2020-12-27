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
    public partial class FrmPrikaziMec : Form
    {
        DateTimePicker dtpDatumDo;
        DateTimePicker dtpDatumOd;
        ComboBox cmbLiga;
        public FrmPrikaziMec(DateTimePicker dtpDatumDo, DateTimePicker dtpDatumOd, ComboBox cmbLiga)
        {
            InitializeComponent();
            this.dtpDatumDo = dtpDatumDo;
            this.dtpDatumOd = dtpDatumOd;
            this.cmbLiga = cmbLiga;
        }

        private void FrmPrikaziMec_Load(object sender, EventArgs e)
        {
            KontrolerKI.PopuniPoljaMeca(cmbDomacin,cmbGost,txtDatumVreme,cmbHala, cmbStatus,txtSetovaDomacin,txtSetovaGost, dataGridView1, cmbLiga);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            KontrolerKI.IzracunajRezultat(txtSetovaDomacin, txtSetovaGost, dataGridView1);
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            KontrolerKI.IzracunajRezultat(txtSetovaDomacin, txtSetovaGost, dataGridView1);
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(KontrolerKI.SacuvajMec(cmbDomacin, cmbGost, cmbHala, cmbStatus, txtDatumVreme, txtSetovaDomacin, txtSetovaGost, dataGridView1, dtpDatumOd,dtpDatumDo,cmbLiga))
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                this.Close();
            }
            
        }
    }
}
