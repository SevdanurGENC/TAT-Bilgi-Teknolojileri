namespace TATBilgiTeknolojileri
{
    partial class frmOturumAcilisi
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
            this.btnSistemeGiris = new System.Windows.Forms.Button();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSistemeGiris
            // 
            this.btnSistemeGiris.Location = new System.Drawing.Point(321, 12);
            this.btnSistemeGiris.Name = "btnSistemeGiris";
            this.btnSistemeGiris.Size = new System.Drawing.Size(146, 44);
            this.btnSistemeGiris.TabIndex = 0;
            this.btnSistemeGiris.Text = "G I R I S";
            this.btnSistemeGiris.UseVisualStyleBackColor = true;
            this.btnSistemeGiris.Click += new System.EventHandler(this.btnSistemeGiris_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(111, 12);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(204, 20);
            this.txtKullaniciAdi.TabIndex = 1;
            this.txtKullaniciAdi.Text = "HS";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(111, 38);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(204, 20);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.Text = "123";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanici Adi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sifre";
            // 
            // frmOturumAcilisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 67);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.btnSistemeGiris);
            this.Name = "frmOturumAcilisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAT Bilgi Teknolojileri - Bilgi Yonetim Sistemi.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSistemeGiris;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

