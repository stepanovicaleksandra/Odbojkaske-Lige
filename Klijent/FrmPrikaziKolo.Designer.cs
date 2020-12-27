namespace Klijent
{
    partial class FrmPrikaziKolo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrikaziKolo));
            this.gbKolo = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.txtDelegat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.gbMec = new System.Windows.Forms.GroupBox();
            this.btnDodajMec = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLiga = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbKolo.SuspendLayout();
            this.gbMec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKolo
            // 
            this.gbKolo.Controls.Add(this.button1);
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
            this.gbKolo.Location = new System.Drawing.Point(23, 21);
            this.gbKolo.Name = "gbKolo";
            this.gbKolo.Size = new System.Drawing.Size(678, 543);
            this.gbKolo.TabIndex = 1;
            this.gbKolo.TabStop = false;
            this.gbKolo.Text = "Kolo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 31);
            this.button1.TabIndex = 24;
            this.button1.Text = "Obriši kolo";
            this.button1.UseVisualStyleBackColor = true;
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
            this.txtDelegat.Location = new System.Drawing.Point(469, 508);
            this.txtDelegat.Name = "txtDelegat";
            this.txtDelegat.ReadOnly = true;
            this.txtDelegat.Size = new System.Drawing.Size(166, 20);
            this.txtDelegat.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(416, 511);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Delegat:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(95, 457);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(166, 31);
            this.btnSacuvaj.TabIndex = 20;
            this.btnSacuvaj.Text = "Sačuvaj kolo";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // gbMec
            // 
            this.gbMec.Controls.Add(this.btnDodajMec);
            this.gbMec.Controls.Add(this.btnDodaj);
            this.gbMec.Controls.Add(this.dataGridView1);
            this.gbMec.Controls.Add(this.btnObrisi);
            this.gbMec.Location = new System.Drawing.Point(15, 108);
            this.gbMec.Name = "gbMec";
            this.gbMec.Size = new System.Drawing.Size(636, 343);
            this.gbMec.TabIndex = 10;
            this.gbMec.TabStop = false;
            this.gbMec.Text = "Mečevi";
            // 
            // btnDodajMec
            // 
            this.btnDodajMec.Location = new System.Drawing.Point(233, 19);
            this.btnDodajMec.Name = "btnDodajMec";
            this.btnDodajMec.Size = new System.Drawing.Size(166, 31);
            this.btnDodajMec.TabIndex = 20;
            this.btnDodajMec.Text = "Dodaj meč";
            this.btnDodajMec.UseVisualStyleBackColor = true;
            this.btnDodajMec.Click += new System.EventHandler(this.btnDodajMec_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(33, 19);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(166, 31);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Izmeni meč";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(607, 254);
            this.dataGridView1.TabIndex = 19;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(432, 19);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(166, 31);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obriši meč";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
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
            // FrmPrikaziKolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.gbKolo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrikaziKolo";
            this.Text = "Detalji o kolu";
            this.Load += new System.EventHandler(this.FrmPrikaziKolo_Load);
            this.gbKolo.ResumeLayout(false);
            this.gbKolo.PerformLayout();
            this.gbMec.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKolo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.TextBox txtDelegat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.GroupBox gbMec;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLiga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodajMec;
    }
}