namespace TATBilgiTeknolojileri.PresentationLayer
{
    partial class frmMalzemeBilgisayar
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMsOffice = new System.Windows.Forms.TextBox();
            this.txtSistemYazilimi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSistemReferansNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAygitCdRw = new System.Windows.Forms.TextBox();
            this.txtDisc = new System.Windows.Forms.TextBox();
            this.txtMemory = new System.Windows.Forms.TextBox();
            this.txtCpu = new System.Windows.Forms.TextBox();
            this.txtMarkaModel = new System.Windows.Forms.TextBox();
            this.txtKullaniciTamIsmi = new System.Windows.Forms.TextBox();
            this.txtKullaniciIsmi = new System.Windows.Forms.TextBox();
            this.txtDepartman = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(6, 466);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(321, 32);
            this.btnKaydet.TabIndex = 22;
            this.btnKaydet.Text = "Yeni Verileri Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(353, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(824, 611);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(6, 504);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(321, 32);
            this.btnGuncelle.TabIndex = 23;
            this.btnGuncelle.Text = "Degisiklikleri Kaydet";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(6, 542);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(321, 32);
            this.btnSil.TabIndex = 24;
            this.btnSil.Text = "Secilen Kayda Ait Bilgileri Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(343, 611);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btnSil);
            this.tabPage1.Controls.Add(this.btnKaydet);
            this.tabPage1.Controls.Add(this.btnGuncelle);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(335, 585);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kayit Islemleri";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAciklama);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtMsOffice);
            this.panel1.Controls.Add(this.txtSistemYazilimi);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtSistemReferansNo);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtAygitCdRw);
            this.panel1.Controls.Add(this.txtDisc);
            this.panel1.Controls.Add(this.txtMemory);
            this.panel1.Controls.Add(this.txtCpu);
            this.panel1.Controls.Add(this.txtMarkaModel);
            this.panel1.Controls.Add(this.txtKullaniciTamIsmi);
            this.panel1.Controls.Add(this.txtKullaniciIsmi);
            this.panel1.Controls.Add(this.txtDepartman);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 454);
            this.panel1.TabIndex = 12;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(134, 372);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(181, 76);
            this.txtAciklama.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 375);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Aciklama";
            // 
            // txtMsOffice
            // 
            this.txtMsOffice.Location = new System.Drawing.Point(134, 341);
            this.txtMsOffice.Name = "txtMsOffice";
            this.txtMsOffice.Size = new System.Drawing.Size(181, 20);
            this.txtMsOffice.TabIndex = 28;
            // 
            // txtSistemYazilimi
            // 
            this.txtSistemYazilimi.Location = new System.Drawing.Point(134, 308);
            this.txtSistemYazilimi.Name = "txtSistemYazilimi";
            this.txtSistemYazilimi.Size = new System.Drawing.Size(181, 20);
            this.txtSistemYazilimi.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 342);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Ms Office";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 311);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Sistem Yazilimi";
            // 
            // txtSistemReferansNo
            // 
            this.txtSistemReferansNo.Location = new System.Drawing.Point(134, 281);
            this.txtSistemReferansNo.Name = "txtSistemReferansNo";
            this.txtSistemReferansNo.Size = new System.Drawing.Size(181, 20);
            this.txtSistemReferansNo.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Sistem Referas No";
            // 
            // txtAygitCdRw
            // 
            this.txtAygitCdRw.Location = new System.Drawing.Point(134, 250);
            this.txtAygitCdRw.Name = "txtAygitCdRw";
            this.txtAygitCdRw.Size = new System.Drawing.Size(181, 20);
            this.txtAygitCdRw.TabIndex = 21;
            // 
            // txtDisc
            // 
            this.txtDisc.Location = new System.Drawing.Point(134, 217);
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Size = new System.Drawing.Size(181, 20);
            this.txtDisc.TabIndex = 20;
            // 
            // txtMemory
            // 
            this.txtMemory.Location = new System.Drawing.Point(134, 187);
            this.txtMemory.Name = "txtMemory";
            this.txtMemory.Size = new System.Drawing.Size(181, 20);
            this.txtMemory.TabIndex = 19;
            // 
            // txtCpu
            // 
            this.txtCpu.Location = new System.Drawing.Point(134, 158);
            this.txtCpu.Name = "txtCpu";
            this.txtCpu.Size = new System.Drawing.Size(181, 20);
            this.txtCpu.TabIndex = 18;
            // 
            // txtMarkaModel
            // 
            this.txtMarkaModel.Location = new System.Drawing.Point(134, 129);
            this.txtMarkaModel.Name = "txtMarkaModel";
            this.txtMarkaModel.Size = new System.Drawing.Size(181, 20);
            this.txtMarkaModel.TabIndex = 17;
            // 
            // txtKullaniciTamIsmi
            // 
            this.txtKullaniciTamIsmi.Location = new System.Drawing.Point(133, 95);
            this.txtKullaniciTamIsmi.Name = "txtKullaniciTamIsmi";
            this.txtKullaniciTamIsmi.Size = new System.Drawing.Size(181, 20);
            this.txtKullaniciTamIsmi.TabIndex = 16;
            // 
            // txtKullaniciIsmi
            // 
            this.txtKullaniciIsmi.Location = new System.Drawing.Point(133, 65);
            this.txtKullaniciIsmi.Name = "txtKullaniciIsmi";
            this.txtKullaniciIsmi.Size = new System.Drawing.Size(181, 20);
            this.txtKullaniciIsmi.TabIndex = 15;
            // 
            // txtDepartman
            // 
            this.txtDepartman.Location = new System.Drawing.Point(133, 32);
            this.txtDepartman.Name = "txtDepartman";
            this.txtDepartman.Size = new System.Drawing.Size(181, 20);
            this.txtDepartman.TabIndex = 14;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(133, 1);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(181, 20);
            this.txtID.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Aygit Cd Rw";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Memory";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Disc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Marka Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cpu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kullanici Ismi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kullanici Tam Ismi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Departman";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.btnRapor);
            this.tabPage2.Controls.Add(this.btnListele);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(335, 585);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listeleme Ve Raporlama";
            // 
            // btnRapor
            // 
            this.btnRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRapor.Location = new System.Drawing.Point(6, 543);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(321, 32);
            this.btnRapor.TabIndex = 29;
            this.btnRapor.Text = "Rapor Al";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListele.Location = new System.Drawing.Point(6, 503);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(321, 32);
            this.btnListele.TabIndex = 28;
            this.btnListele.Text = "Kriterlere Gore Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox5);
            this.panel2.Controls.Add(this.checkBox4);
            this.panel2.Controls.Add(this.checkBox3);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 287);
            this.panel2.TabIndex = 27;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Enabled = false;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(32, 142);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(240, 17);
            this.checkBox5.TabIndex = 30;
            this.checkBox5.Text = "Sistem Yazilimi, MsOffice ve Aciklama";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(32, 119);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(138, 17);
            this.checkBox4.TabIndex = 29;
            this.checkBox4.Text = "Sistem Referans No";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(32, 96);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(223, 17);
            this.checkBox3.TabIndex = 28;
            this.checkBox3.Text = "Cpu, Memory, Disc ve Aygit Cd Rw";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(32, 73);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(99, 17);
            this.checkBox2.TabIndex = 27;
            this.checkBox2.Text = "Marka Model";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(32, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(293, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Departman, Kullanici Ismi ve Kullanici Tam Ismi";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(5, 27);
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
            this.radioButton1.Location = new System.Drawing.Point(5, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(148, 17);
            this.radioButton1.TabIndex = 24;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tum Listeyi Goruntule";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(353, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(824, 611);
            this.dataGridView2.TabIndex = 28;
            // 
            // frmMalzemeBilgisayar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 621);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMalzemeBilgisayar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAT Bilgi Teknolojileri - Bilgi Yonetim Sistemi | Malzeme, Depo ve Envanter Harek" +
    "etleri - Bilgisayar";
            this.Load += new System.EventHandler(this.frmMalzemeBilgisayar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMsOffice;
        private System.Windows.Forms.TextBox txtSistemYazilimi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSistemReferansNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAygitCdRw;
        private System.Windows.Forms.TextBox txtDisc;
        private System.Windows.Forms.TextBox txtMemory;
        private System.Windows.Forms.TextBox txtCpu;
        private System.Windows.Forms.TextBox txtMarkaModel;
        private System.Windows.Forms.TextBox txtKullaniciTamIsmi;
        private System.Windows.Forms.TextBox txtKullaniciIsmi;
        private System.Windows.Forms.TextBox txtDepartman;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}