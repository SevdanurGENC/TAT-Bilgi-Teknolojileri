using System;
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
    public partial class frmDemirbasBilgisayarEkrani : Form
    {
        private TblDemirbasBilgisayarBLL _TblDemirbasBilgisayarBLL;
        public SqlCommand sorgu;

        public frmDemirbasBilgisayarEkrani()
        {
            InitializeComponent();
            _TblDemirbasBilgisayarBLL = new TblDemirbasBilgisayarBLL();
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

        private void frmDemirbasBilgisayarEkrani_Load(object sender, EventArgs e)
        {
            ListeyiAktifEt();

            VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
            sorgu = new SqlCommand("Select * from Tbl_DemirbasBilgisayar", yeniBaglanti.baglanti);

            Listele();

            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
            checkBox7.Enabled = false;
            checkBox8.Enabled = false;
            checkBox9.Enabled = false;
            checkBox10.Enabled = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TblDemirbasBilgisayarPoco DemirbasBilgisayar = new TblDemirbasBilgisayarPoco();
            DemirbasBilgisayar = _TblDemirbasBilgisayarBLL.kaydetDemirbasBilgisayar(Convert.ToInt32(txtID.Text), txtDepartman.Text,
                txtMakinaIsmi.Text, txtKullaniciIsmi.Text, txtKullaniciTamIsmi.Text, txtEkran.Text, txtMailAdresi.Text, txtAciklama.Text,
                txtIp.Text, txtMarkaModel.Text, txtModel.Text, txtCpu.Text, txtMemory.Text, txtDisc.Text, txtAygitCdRw.Text,
                txtSistemReferansNo.Text, txtEkranReferansNo.Text, txtSistemYazilimi.Text, txtMsOffice.Text, txtNotBilgisi.Text, 
                txtYeniPcVerilisTarihi.Text);

            MessageBox.Show("Kaydiniz Tamamlanmistir...");
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            TblDemirbasBilgisayarPoco DemirbasBilgisayar = new TblDemirbasBilgisayarPoco();
            DemirbasBilgisayar = _TblDemirbasBilgisayarBLL.guncelleDemirbasBilgisayar(Convert.ToInt32(txtID.Text), txtDepartman.Text,
                txtMakinaIsmi.Text, txtKullaniciIsmi.Text, txtKullaniciTamIsmi.Text, txtEkran.Text, txtMailAdresi.Text, txtAciklama.Text,
                txtIp.Text, txtMarkaModel.Text, txtModel.Text, txtCpu.Text, txtMemory.Text, txtDisc.Text, txtAygitCdRw.Text,
                txtSistemReferansNo.Text, txtEkranReferansNo.Text, txtSistemYazilimi.Text, txtMsOffice.Text, txtNotBilgisi.Text,
                txtYeniPcVerilisTarihi.Text);

            MessageBox.Show("Guncelleme Isleminiz Tamamlanmistir...");
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            TblDemirbasBilgisayarPoco DemirbasBilgisayar = new TblDemirbasBilgisayarPoco();
            DemirbasBilgisayar = _TblDemirbasBilgisayarBLL.silDemirbasBilgisayar(Convert.ToInt32(txtID.Text));

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
            checkBox6.Enabled = false;
            checkBox7.Enabled = false;
            checkBox8.Enabled = false;
            checkBox9.Enabled = false;
            checkBox10.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;
            checkBox6.Enabled = true;
            checkBox7.Enabled = true;
            checkBox8.Enabled = true;
            checkBox9.Enabled = true;
            checkBox10.Enabled = false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtDepartman.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtMakinaIsmi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtKullaniciIsmi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtKullaniciTamIsmi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtEkran.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtMailAdresi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtIp.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtMarkaModel.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtModel.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtCpu.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtMemory.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            txtDisc.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            txtAygitCdRw.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            txtSistemReferansNo.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            txtEkranReferansNo.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            txtSistemYazilimi.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            txtMsOffice.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            txtNotBilgisi.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
            txtYeniPcVerilisTarihi.Text = dataGridView1.CurrentRow.Cells[20].Value.ToString();
          
        }

        public string degisken1;
        public string degisken2;
        public string degisken3;
        public string degisken4;
        public string degisken5;
        public string degisken6;
        public string degisken7;
        public string degisken8;
        public string degisken9;
        public string degisken10;

        private void btnListele_Click(object sender, EventArgs e)
        {
            ListeyiPasifYap();

            if (radioButton1.Checked == true)
            {
                VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
                sorgu = new SqlCommand("Select * from Tbl_DemirbasBilgisayar", yeniBaglanti.baglanti);
                ListeleIki();
            }

            if (radioButton2.Checked == true)
            {
                if (checkBox1.Checked == true)
                    degisken1 = "Departman, KullaniciIsmi, KullaniciTamIsmi, MailAdresi,";
                else
                    degisken1 = "";

                if (checkBox2.Checked == true)
                    degisken2 = "MakinaIsmi,";
                else
                    degisken2 = "";

                if (checkBox3.Checked == true)
                    degisken3 = "Ekran,";
                else
                    degisken3 = "";

                if (checkBox4.Checked == true)
                    degisken4 = "Ip,";
                else
                    degisken4 = "";

                if (checkBox5.Checked == true)
                    degisken5 = "YeniPcVerilisTarihi,";
                else
                    degisken5 = "";
                 
                if (checkBox6.Checked == true)
                    degisken6 = "Model, MarkaModel,";
                else
                    degisken6 = "";

                if (checkBox7.Checked == true)
                    degisken7 = "Cpu, Memory, Disc, AygitCdRw,";
                else
                    degisken7 = "";

                if (checkBox8.Checked == true)
                    degisken8 = "SistemReferansNo, EkranReferansNo,";
                else
                    degisken8 = "";

                if (checkBox9.Checked == true)
                    degisken9 = "SistemYazilimi, MsOffice,";
                else
                    degisken9 = "";

                if (checkBox10.Checked == true)
                    degisken10 = "Aciklama, NotBilgisi";
                else
                    degisken10 = "";
                 
                VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
                sorgu = new SqlCommand("Select " + degisken1 + degisken2 + degisken3 + degisken4 + degisken5 + degisken6 + degisken7 + degisken8 + degisken9 + degisken10 + " from Tbl_DemirbasBilgisayar", yeniBaglanti.baglanti);
                ListeleIki();
            } 
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            Document document = new Document(PageSize.A4, 10, 10, 50, 10);
            PdfWriter pw = PdfWriter.GetInstance(document, new FileStream("C:\\Users\\Sevdanur\\Documents\\Visual Studio 2010\\Projects\\TATBilgiTeknolojileri\\TATBilgiTeknolojileri\\Report\\ReportOfDemirbasBilgisayar.pdf", FileMode.Create));
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

            System.Diagnostics.Process.Start("C:\\Users\\Sevdanur\\Documents\\Visual Studio 2010\\Projects\\TATBilgiTeknolojileri\\TATBilgiTeknolojileri\\Report\\ReportOfDemirbasBilgisayar.pdf");

            ListeyiAktifEt();
        }
         



    }
}
