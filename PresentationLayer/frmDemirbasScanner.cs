﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TATBilgiTeknolojileri.PocosLayer;
using TATBilgiTeknolojileri.BusinessLogicLayer;
using TATBilgiTeknolojileri.DataAccessObjects;
using System.Data.SqlClient;

using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace TATBilgiTeknolojileri.PresentationLayer
{
    public partial class frmDemirbasScanner : Form
    {
        private TblDemirbasScannerBLL _TblDemirbasScannerBLL;
        public SqlCommand sorgu;

        public frmDemirbasScanner()
        {
            InitializeComponent();
            _TblDemirbasScannerBLL = new TblDemirbasScannerBLL();
        }

        public void ListeyiAktifEt()  //dg1 aktif, dg2 pasif
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
        }

        public void ListeyiPasifYap()   //dg2 aktif, dg1 pasif
        {
            dataGridView2.Visible = true;
            dataGridView1.Visible = false;
        }

        public void Listele()
        {
            ListeyiAktifEt();
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);
            adapter.Fill(dataTable);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;
        }

        public void ListeleIki()
        {
            ListeyiPasifYap();
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);
            adapter.Fill(dataTable);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView2.DataSource = bindingSource;
        }

        private void frmDemirbasScanner_Load(object sender, EventArgs e)
        {
            ListeyiAktifEt();

            VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
            sorgu = new SqlCommand("Select * from Tbl_DemirbasScanner", yeniBaglanti.baglanti);

            Listele();

            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
        }
         
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TblDemirbasScannerPoco DemirbasScanner = new TblDemirbasScannerPoco();
            DemirbasScanner = _TblDemirbasScannerBLL.kaydetDemirbasScanner(Convert.ToInt32(txtID.Text),
                txtModel.Text, txtTip.Text, txtReferansNo.Text, txtDepartman.Text, txtKullanici.Text, 
                txtYeniScannerVerilisTarihi.Text);

            MessageBox.Show("Kaydiniz Tamamlanmistir...");
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            TblDemirbasScannerPoco DemirbasScanner = new TblDemirbasScannerPoco();
            DemirbasScanner = _TblDemirbasScannerBLL.guncelleDemirbasScanner(Convert.ToInt32(txtID.Text),
                txtModel.Text, txtTip.Text, txtReferansNo.Text, txtDepartman.Text, txtKullanici.Text,
                txtYeniScannerVerilisTarihi.Text);

            MessageBox.Show("Guncelleme Isleminiz Tamamlanmistir...");
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            TblDemirbasScannerPoco DemirbasScanner = new TblDemirbasScannerPoco();
            DemirbasScanner = _TblDemirbasScannerBLL.silDemirbasScanner(Convert.ToInt32(txtID.Text));

            MessageBox.Show("Silme Isleminiz Tamamlanmistir...");
            Listele();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtModel.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtTip.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtReferansNo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtDepartman.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtKullanici.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtYeniScannerVerilisTarihi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
          
        }
         
        public string degisken1;
        public string degisken2;
        public string degisken3;
        public string degisken4;
        public string degisken5;

        private void btnListele_Click(object sender, EventArgs e)
        {
            ListeyiPasifYap();

            if (radioButton1.Checked == true)
            {
                VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
                sorgu = new SqlCommand("Select * from Tbl_DemirbasScanner", yeniBaglanti.baglanti);
                ListeleIki();
            }

            if (radioButton2.Checked == true)
            {
                if (checkBox1.Checked == true)
                    degisken1 = "Model,";
                else
                    degisken1 = "";

                if (checkBox2.Checked == true)
                    degisken2 = "Tip,";
                else
                    degisken2 = "";

                if (checkBox3.Checked == true)
                    degisken3 = "ReferansNo,";
                else
                    degisken3 = "";

                if (checkBox4.Checked == true)
                    degisken4 = "YeniScannerVerilisTarihi,";
                else
                    degisken4 = "";

                if (checkBox5.Checked == true)
                    degisken5 = "Departman, Kullanici";
                else
                    degisken5 = "";

                VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
                sorgu = new SqlCommand("Select " + degisken1 + degisken2 + degisken3 + degisken4 + degisken5 + " from Tbl_DemirbasScanner", yeniBaglanti.baglanti);
                ListeleIki();
            } 
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
               Document document = new Document(PageSize.A4, 10, 10, 50, 10);
            PdfWriter pw = PdfWriter.GetInstance(document, new FileStream("C:\\Users\\Sevdanur\\Documents\\Visual Studio 2010\\Projects\\TATBilgiTeknolojileri\\TATBilgiTeknolojileri\\Report\\ReportOfDemirbasScanner.pdf", FileMode.Create));
            document.Open();

            PdfPTable table = new PdfPTable(dataGridView2.Columns.Count);
            for (int j = 0; j < dataGridView2.Columns.Count; j++)
            {
                table.AddCell(new Phrase(dataGridView2.Columns[j].HeaderText));
            }

            table.HeaderRows = 1;

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                for (int k = 0; k < dataGridView2.Columns.Count; k++)
                {
                    if (dataGridView1[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(dataGridView2[k, i].Value.ToString()));
                    }
                }
            }

            document.Add(table);
            document.Close();

            System.Diagnostics.Process.Start("C:\\Users\\Sevdanur\\Documents\\Visual Studio 2010\\Projects\\TATBilgiTeknolojileri\\TATBilgiTeknolojileri\\Report\\ReportOfDemirbasScanner.pdf");

            ListeyiAktifEt();
        }
      
    }
}
