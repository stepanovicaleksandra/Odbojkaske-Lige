namespace Klijent
{
    partial class FrmUnosKola
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnosKola));
            this.gbKolo = new System.Windows.Forms.GroupBox();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.txtDelegat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.gbMec = new System.Windows.Forms.GroupBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDatumVreme = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbHala = new System.Windows.Forms.ComboBox();
            this.Ha = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGost = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDomacin = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLiga = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.btnKreirajKolo = new System.Windows.Forms.Button();
            this.gbKolo.SuspendLayout();
            this.gbMec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKolo
            // 
            this.gbKolo.Controls.Add(this.dtpDatumDo);
            this.gbKolo.Controls.Add(this.dtpDatumOd);
            this.gbKolo.Controls.Add(this.txtDelegat);
            this.gbKolo.Controls.Add(this.label10);
            this.gbKolo.Controls.Add(this.btnSacuvaj);
            this.gbKolo.Controls.Add(this.gbMec);
            this.gbKolo.Controls.Add(this.label5);
            this.gbKolo.Controls.Add(this.label4);
            this.gbKolo.Controls.Add(this.txtNaziv);
            this.gbKolo.Controls.Add(this.label3);
            this.gbKolo.Controls.Add(this.cmbLiga);
            this.gbKolo.Controls.Add(this.label2);
            this.gbKolo.Enabled = false;
            this.gbKolo.Location = new System.Drawing.Point(21, 61);
            this.gbKolo.Name = "gbKolo";
            this.gbKolo.Size = new System.Drawing.Size(694, 583);
            this.gbKolo.TabIndex = 0;
            this.gbKolo.TabStop = false;
            this.gbKolo.Text = "Detalji o kolu";
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Location = new System.Drawing.Point(405, 64);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(189, 20);
            this.dtpDatumDo.TabIndex = 23;
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Location = new System.Drawing.Point(405, 31);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(189, 20);
            this.dtpDatumOd.TabIndex = 22;
            // 
            // txtDelegat
            // 
            this.txtDelegat.Location = new System.Drawing.Point(477, 557);
            this.txtDelegat.Name = "txtDelegat";
            this.txtDelegat.ReadOnly = true;
            this.txtDelegat.Size = new System.Drawing.Size(166, 20);
            this.txtDelegat.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(424, 560);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Delegat:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(233, 518);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(166, 31);
            this.btnSacuvaj.TabIndex = 20;
            this.btnSacuvaj.Text = "Sačuvaj kolo";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // gbMec
            // 
            this.gbMec.Controls.Add(this.btnObrisi);
            this.gbMec.Controls.Add(this.btnDodaj);
            this.gbMec.Controls.Add(this.dataGridView1);
            this.gbMec.Controls.Add(this.txtDatumVreme);
            this.gbMec.Controls.Add(this.label9);
            this.gbMec.Controls.Add(this.cmbHala);
            this.gbMec.Controls.Add(this.Ha);
            this.gbMec.Controls.Add(this.cmbStatus);
            this.gbMec.Controls.Add(this.label8);
            this.gbMec.Controls.Add(this.cmbGost);
            this.gbMec.Controls.Add(this.label7);
            this.gbMec.Controls.Add(this.cmbDomacin);
            this.gbMec.Controls.Add(this.label6);
            this.gbMec.Location = new System.Drawing.Point(15, 114);
            this.gbMec.Name = "gbMec";
            this.gbMec.Size = new System.Drawing.Size(662, 398);
            this.gbMec.TabIndex = 10;
            this.gbMec.TabStop = false;
            this.gbMec.Text = "Unos meča:";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(361, 147);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(166, 31);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obriši meč";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(100, 147);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(166, 31);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj meč";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(635, 199);
            this.dataGridView1.TabIndex = 19;
            // 
            // txtDatumVreme
            // 
            this.txtDatumVreme.Location = new System.Drawing.Point(100, 62);
            this.txtDatumVreme.Name = "txtDatumVreme";
            this.txtDatumVreme.Size = new System.Drawing.Size(188, 20);
            this.txtDatumVreme.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Datum i vreme:";
            // 
            // cmbHala
            // 
            this.cmbHala.FormattingEnabled = true;
            this.cmbHala.Location = new System.Drawing.Point(390, 62);
            this.cmbHala.Name = "cmbHala";
            this.cmbHala.Size = new System.Drawing.Size(191, 21);
            this.cmbHala.TabIndex = 18;
            // 
            // Ha
            // 
            this.Ha.AutoSize = true;
            this.Ha.Location = new System.Drawing.Point(323, 65);
            this.Ha.Name = "Ha";
            this.Ha.Size = new System.Drawing.Size(32, 13);
            this.Ha.TabIndex = 17;
            this.Ha.Text = "Hala:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(100, 106);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(188, 21);
            this.cmbStatus.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Status meča:";
            // 
            // cmbGost
            // 
            this.cmbGost.Enabled = false;
            this.cmbGost.FormattingEnabled = true;
            this.cmbGost.Location = new System.Drawing.Point(390, 19);
            this.cmbGost.Name = "cmbGost";
            this.cmbGost.Size = new System.Drawing.Size(191, 21);
            this.cmbGost.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Gost:";
            // 
            // cmbDomacin
            // 
            this.cmbDomacin.Enabled = false;
            this.cmbDomacin.FormattingEnabled = true;
            this.cmbDomacin.Location = new System.Drawing.Point(100, 19);
            this.cmbDomacin.Name = "cmbDomacin";
            this.cmbDomacin.Size = new System.Drawing.Size(188, 21);
            this.cmbDomacin.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Domaćin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Datum završetka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Datum početka:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(115, 68);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(188, 20);
            this.txtNaziv.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Naziv kola:";
            // 
            // cmbLiga
            // 
            this.cmbLiga.FormattingEnabled = true;
            this.cmbLiga.Location = new System.Drawing.Point(115, 28);
            this.cmbLiga.Name = "cmbLiga";
            this.cmbLiga.Size = new System.Drawing.Size(188, 21);
            this.cmbLiga.TabIndex = 5;
            this.cmbLiga.SelectedIndexChanged += new System.EventHandler(this.cmbLiga_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Liga:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Šifra kola:";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(256, 17);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.ReadOnly = true;
            this.txtSifra.Size = new System.Drawing.Size(135, 20);
            this.txtSifra.TabIndex = 2;
            // 
            // btnKreirajKolo
            // 
            this.btnKreirajKolo.Location = new System.Drawing.Point(21, 15);
            this.btnKreirajKolo.Name = "btnKreirajKolo";
            this.btnKreirajKolo.Size = new System.Drawing.Size(141, 31);
            this.btnKreirajKolo.TabIndex = 3;
            this.btnKreirajKolo.Text = "Kreiraj kolo";
            this.btnKreirajKolo.UseVisualStyleBackColor = true;
            this.btnKreirajKolo.Click += new System.EventHandler(this.btnKreirajKolo_Click);
            // 
            // FrmUnosKola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 644);
            this.Controls.Add(this.btnKreirajKolo);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbKolo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUnosKola";
            this.Text = "Unos novog kola";
            this.Load += new System.EventHandler(this.FrmUnosKola_Load);
            this.gbKolo.ResumeLayout(false);
            this.gbKolo.PerformLayout();
            this.gbMec.ResumeLayout(false);
            this.gbMec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKolo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Button btnKreirajKolo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLiga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbMec;
        private System.Windows.Forms.ComboBox cmbGost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDomacin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDatumVreme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbHala;
        private System.Windows.Forms.Label Ha;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDelegat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
    }
}