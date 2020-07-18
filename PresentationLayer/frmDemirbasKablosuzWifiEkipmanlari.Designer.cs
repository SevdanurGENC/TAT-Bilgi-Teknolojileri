namespace TATBilgiTeknolojileri.PresentationLayer
{
    partial class frmDemirbasKablosuzWifiEkipmanlari
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
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtCihazAdi = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(273, 86);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(179, 33);
            this.btnSil.TabIndex = 44;
            this.btnSil.Text = "Secilen Kayda Ait Bilgileri Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(804, 454);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Listeleme ve Raporlama Islemleri";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(273, 13);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(179, 32);
            this.btnKaydet.TabIndex = 42;
            this.btnKaydet.Text = "Yeni Verileri Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(273, 51);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(179, 32);
            this.btnGuncelle.TabIndex = 43;
            this.btnGuncelle.Text = "Degisiklikleri Kaydet";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnRapor);
            this.panel2.Controls.Add(this.btnListele);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Location = new System.Drawing.Point(477, 471);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 139);
            this.panel2.TabIndex = 48;
            // 
            // btnRapor
            // 
            this.btnRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRapor.Location = new System.Drawing.Point(190, 81);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(142, 32);
            this.btnRapor.TabIndex = 43;
            this.btnRapor.Text = "Rapor Al";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListele.Location = new System.Drawing.Point(190, 46);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(142, 32);
            this.btnListele.TabIndex = 42;
            this.btnListele.Text = "Kriterlere Gore Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Enabled = false;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(32, 96);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(77, 17);
            this.checkBox2.TabIndex = 27;
            this.checkBox2.Text = "Aciklama";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(32, 73);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Cihaz Adi";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(5, 50);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(178, 17);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.Text = "Kendi Listenizi Olusturunuz";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(5, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(148, 17);
            this.radioButton1.TabIndex = 24;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tum Listeyi Goruntule";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(75, 64);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(192, 71);
            this.txtAciklama.TabIndex = 15;
            // 
            // txtCihazAdi
            // 
            this.txtCihazAdi.Location = new System.Drawing.Point(75, 40);
            this.txtCihazAdi.Name = "txtCihazAdi";
            this.txtCihazAdi.Size = new System.Drawing.Size(192, 20);
            this.txtCihazAdi.TabIndex = 14;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(75, 13);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(192, 20);
            this.txtID.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.txtAciklama);
            this.panel1.Controls.Add(this.txtCihazAdi);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 471);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 139);
            this.panel1.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aciklama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cihaz Adi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 11);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(804, 454);
            this.dataGridView2.TabIndex = 46;
            // 
            // frmDemirbasKablosuzWifiEkipmanlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 621);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "frmDemirbasKablosuzWifiEkipmanlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAT Bilgi Teknolojileri - Bilgi Yonetim Sistemi | Demirbas Envanter Ekranlari - K" +
    "ablosuz Wifi Ekipmanlari";
            this.Load += new System.EventHandler(this.frmDemirbasKablosuzWifiEkipmanlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtCihazAdi;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}