namespace Klijent
{
    partial class FrmPocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPocetna));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.timToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovogTimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaTimovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovogMolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaKolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timToolStripMenuItem,
            this.koloToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(466, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // timToolStripMenuItem
            // 
            this.timToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNovogTimaToolStripMenuItem,
            this.pretragaTimovaToolStripMenuItem});
            this.timToolStripMenuItem.Name = "timToolStripMenuItem";
            this.timToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.timToolStripMenuItem.Text = "Tim";
            // 
            // unosNovogTimaToolStripMenuItem
            // 
            this.unosNovogTimaToolStripMenuItem.Name = "unosNovogTimaToolStripMenuItem";
            this.unosNovogTimaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.unosNovogTimaToolStripMenuItem.Text = "Unos novog tima";
            this.unosNovogTimaToolStripMenuItem.Click += new System.EventHandler(this.unosNovogTimaToolStripMenuItem_Click);
            // 
            // pretragaTimovaToolStripMenuItem
            // 
            this.pretragaTimovaToolStripMenuItem.Name = "pretragaTimovaToolStripMenuItem";
            this.pretragaTimovaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.pretragaTimovaToolStripMenuItem.Text = "Pretraga timova";
            this.pretragaTimovaToolStripMenuItem.Click += new System.EventHandler(this.pretragaTimovaToolStripMenuItem_Click);
            // 
            // koloToolStripMenuItem
            // 
            this.koloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNovogMolaToolStripMenuItem,
            this.pretragaKolaToolStripMenuItem});
            this.koloToolStripMenuItem.Name = "koloToolStripMenuItem";
            this.koloToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.koloToolStripMenuItem.Text = "Kolo";
            // 
            // unosNovogMolaToolStripMenuItem
            // 
            this.unosNovogMolaToolStripMenuItem.Name = "unosNovogMolaToolStripMenuItem";
            this.unosNovogMolaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.unosNovogMolaToolStripMenuItem.Text = "Unos novog kola";
            this.unosNovogMolaToolStripMenuItem.Click += new System.EventHandler(this.unosNovogMolaToolStripMenuItem_Click);
            // 
            // pretragaKolaToolStripMenuItem
            // 
            this.pretragaKolaToolStripMenuItem.Name = "pretragaKolaToolStripMenuItem";
            this.pretragaKolaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.pretragaKolaToolStripMenuItem.Text = "Pretraga kola";
            this.pretragaKolaToolStripMenuItem.Click += new System.EventHandler(this.pretragaKolaToolStripMenuItem_Click);
            // 
            // FrmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 236);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPocetna";
            this.Text = "PocetnaForma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PocetnaForma_FormClosed);
            this.Load += new System.EventHandler(this.FrmPocetna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem timToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNovogTimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaTimovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNovogMolaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaKolaToolStripMenuItem;
    }
}