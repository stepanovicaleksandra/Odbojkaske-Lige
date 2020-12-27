namespace Klijent
{
    partial class FrmDodajMec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDodajMec));
            this.btnDodaj = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(107, 240);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(166, 31);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj meč";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtDatumVreme
            // 
            this.txtDatumVreme.Location = new System.Drawing.Point(96, 89);
            this.txtDatumVreme.Name = "txtDatumVreme";
            this.txtDatumVreme.Size = new System.Drawing.Size(191, 20);
            this.txtDatumVreme.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Datum i vreme:";
            // 
            // cmbHala
            // 
            this.cmbHala.FormattingEnabled = true;
            this.cmbHala.Location = new System.Drawing.Point(96, 127);
            this.cmbHala.Name = "cmbHala";
            this.cmbHala.Size = new System.Drawing.Size(191, 21);
            this.cmbHala.TabIndex = 18;
            // 
            // Ha
            // 
            this.Ha.AutoSize = true;
            this.Ha.Location = new System.Drawing.Point(14, 130);
            this.Ha.Name = "Ha";
            this.Ha.Size = new System.Drawing.Size(32, 13);
            this.Ha.TabIndex = 17;
            this.Ha.Text = "Hala:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(96, 166);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(191, 21);
            this.cmbStatus.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Status meča:";
            // 
            // cmbGost
            // 
            this.cmbGost.FormattingEnabled = true;
            this.cmbGost.Location = new System.Drawing.Point(96, 48);
            this.cmbGost.Name = "cmbGost";
            this.cmbGost.Size = new System.Drawing.Size(191, 21);
            this.cmbGost.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Gost:";
            // 
            // cmbDomacin
            // 
            this.cmbDomacin.FormattingEnabled = true;
            this.cmbDomacin.Location = new System.Drawing.Point(96, 12);
            this.cmbDomacin.Name = "cmbDomacin";
            this.cmbDomacin.Size = new System.Drawing.Size(191, 21);
            this.cmbDomacin.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Domaćin:";
            // 
            // FrmDodajMec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 346);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtDatumVreme);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbHala);
            this.Controls.Add(this.cmbDomacin);
            this.Controls.Add(this.Ha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbGost);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDodajMec";
            this.Text = "Unos meča";
            this.Load += new System.EventHandler(this.FrmDodajMec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtDatumVreme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbHala;
        private System.Windows.Forms.Label Ha;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbGost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDomacin;
        private System.Windows.Forms.Label label6;
    }
}