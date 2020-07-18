namespace TATBilgiTeknolojileri.PresentationLayer
{
    partial class frmKullaniciBilgileriGuncelleme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGridListele = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanici Adi ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sifre ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Isim ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soyisim";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(605, 280);
            this.dataGridView1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnGridListele);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.txtSoyisim);
            this.panel1.Controls.Add(this.txtIsim);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.txtKullaniciAdi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(623, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 279);
            this.panel1.TabIndex = 5;
            // 
            // btnGridListele
            // 
            this.btnGridListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGridListele.Location = new System.Drawing.Point(89, 244);
            this.btnGridListele.Name = "btnGridListele";
            this.btnGridListele.Size = new System.Drawing.Size(201, 23);
            this.btnGridListele.TabIndex = 11;
            this.btnGridListele.Text = "Kullanici Listesini Guncelle";
            this.btnGridListele.UseVisualStyleBackColor = true;
            this.btnGridListele.Click += new System.EventHandler(this.btnGridListele_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(89, 215);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(201, 23);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Kullaniciyi Sistemden Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(89, 186);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(201, 23);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Kullanici Bilgilerini Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(89, 157);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(201, 23);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Yeni Kullanici Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(89, 131);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(201, 20);
            this.txtSoyisim.TabIndex = 7;
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(89, 104);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(201, 20);
            this.txtIsim.TabIndex = 6;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(89, 74);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(201, 20);
            this.txtSifre.TabIndex = 5;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(89, 45);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(201, 20);
            this.txtKullaniciAdi.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(89, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(201, 20);
            this.txtID.TabIndex = 13;
            // 
            // frmKullaniciBilgileriGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 304);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmKullaniciBilgileriGuncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAT Bilgi Teknolojileri - Bilgi Yonetim Sistemi | Ana Ekran Islemleri - Kullanici" +
    " Bilgi Gunceleme Ekrani";
            this.Load += new System.EventHandler(this.frmKullaniciBilgileriGuncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Button btnGridListele;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
    }
}