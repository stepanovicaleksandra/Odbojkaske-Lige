namespace Klijent
{
    partial class FrmUnosTima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnosTima));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMesto = new System.Windows.Forms.TextBox();
            this.btnZapamtiTim = new System.Windows.Forms.Button();
            this.btnKreirajTim = new System.Windows.Forms.Button();
            this.cmbLiga = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mesto:";
            // 
            // txtMesto
            // 
            this.txtMesto.Enabled = false;
            this.txtMesto.Location = new System.Drawing.Point(79, 187);
            this.txtMesto.Name = "txtMesto";
            this.txtMesto.Size = new System.Drawing.Size(180, 20);
            this.txtMesto.TabIndex = 3;
            // 
            // btnZapamtiTim
            // 
            this.btnZapamtiTim.Enabled = false;
            this.btnZapamtiTim.Location = new System.Drawing.Point(79, 227);
            this.btnZapamtiTim.Name = "btnZapamtiTim";
            this.btnZapamtiTim.Size = new System.Drawing.Size(180, 34);
            this.btnZapamtiTim.TabIndex = 4;
            this.btnZapamtiTim.Text = "Zapamti tim";
            this.btnZapamtiTim.UseVisualStyleBackColor = true;
            this.btnZapamtiTim.Click += new System.EventHandler(this.btnZapamtiTim_Click);
            // 
            // btnKreirajTim
            // 
            this.btnKreirajTim.Location = new System.Drawing.Point(79, 12);
            this.btnKreirajTim.Name = "btnKreirajTim";
            this.btnKreirajTim.Size = new System.Drawing.Size(180, 34);
            this.btnKreirajTim.TabIndex = 5;
            this.btnKreirajTim.Text = "Kreiraj nov tim";
            this.btnKreirajTim.UseVisualStyleBackColor = true;
            this.btnKreirajTim.Click += new System.EventHandler(this.btnKreirajTim_Click);
            // 
            // cmbLiga
            // 
            this.cmbLiga.Enabled = false;
            this.cmbLiga.FormattingEnabled = true;
            this.cmbLiga.Location = new System.Drawing.Point(79, 105);
            this.cmbLiga.Name = "cmbLiga";
            this.cmbLiga.Size = new System.Drawing.Size(180, 21);
            this.cmbLiga.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Liga:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Enabled = false;
            this.txtNaziv.Location = new System.Drawing.Point(79, 146);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(180, 20);
            this.txtNaziv.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(79, 66);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(180, 20);
            this.txtId.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Šifra tima:";
            // 
            // FrmUnosTima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 296);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbLiga);
            this.Controls.Add(this.btnKreirajTim);
            this.Controls.Add(this.btnZapamtiTim);
            this.Controls.Add(this.txtMesto);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUnosTima";
            this.Text = "FromUnosTima";
            this.Load += new System.EventHandler(this.FromUnosTima_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMesto;
        private System.Windows.Forms.Button btnZapamtiTim;
        private System.Windows.Forms.Button btnKreirajTim;
        private System.Windows.Forms.ComboBox cmbLiga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
    }
}