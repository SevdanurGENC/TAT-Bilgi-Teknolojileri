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
    public partial class frmDemirbasYazici : Form
    {
        private TblDemirbasYaziciBLL _TblDemirbasYaziciBLL;
        public SqlCommand sorgu;

        public frmDemirbasYazici()
        {
            InitializeComponent();
            _TblDemirbasYaziciBLL = new TblDemirbasYaziciBLL();
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
         
        private void frmDemirbasYazici_Load(object sender, EventArgs e)
        {
            ListeyiAktifEt();

            VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
            sorgu = new SqlCommand("Select * from Tbl_DemirbasYazici", yeniBaglanti.baglanti);

            Listele();

            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false; 
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TblDemirbasYaziciPoco demirbasYazici = new TblDemirbasYaziciPoco();
            demirbasYazici = _TblDemirbasYaziciBLL.kaydetDemirbasServer(Convert.ToInt32(txtID.Text),
                txtModel.Text, txtTip.Text, txtSiyah.Text, txtRenkli.Text, txtMavi.Text, txtSari.Text,
                txtKirmizi.Text, txtDepartman.Text, txtKullanici.Text, txtIp.Text, txtSeriNo.Text,
                txtAciklama.Text);

            MessageBox.Show("Kaydiniz Tamamlanmistir...");
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            TblDemirbasYaziciPoco demirbasYazici = new TblDemirbasYaziciPoco();
            demirbasYazici = _TblDemirbasYaziciBLL.guncelleDemirbasServer(Convert.ToInt32(txtID.Text),
                txtModel.Text, txtTip.Text, txtSiyah.Text, txtRenkli.Text, txtMavi.Text, txtSari.Text,
                txtKirmizi.Text, txtDepartman.Text, txtKullanici.Text, txtIp.Text, txtSeriNo.Text,
                txtAciklama.Text);

            MessageBox.Show("Guncelleme Isleminiz Tamamlanmistir...");
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            TblDemirbasYaziciPoco demirbasYazici = new TblDemirbasYaziciPoco();
            demirbasYazici = _TblDemirbasYaziciBLL.silDemirbasYazici(Convert.ToInt32(txtID.Text));

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
            txtSiyah.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtRenkli.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtMavi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtSari.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtKirmizi.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtDepartman.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtKullanici.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtIp.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtSeriNo.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
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
                sorgu = new SqlCommand("Select * from Tbl_DemirbasYazici", yeniBaglanti.baglanti);
                ListeleIki();
            }

            if (radioButton2.Checked == true)
            {
                if (checkBox1.Checked == true)
                    degisken1 = "Departman, Ip, Kullanici,";
                else
                    degisken1 = "";

                if (checkBox2.Checked == true)
                    degisken2 = "Model, Tip,";
                else
                    degisken2 = "";

                if (checkBox3.Checked == true)
                    degisken3 = "Siyah, Renkli, Mavi, Sari, Kirmizi,";
                else
                    degisken3 = "";

                if (checkBox4.Checked == true)
                    degisken4 = "SeriNo,";
                else
                    degisken4 = "";

                if (checkBox5.Checked == true)
                    degisken5 = "Aciklama";
                else
                    degisken5 = "";

                VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
                sorgu = new SqlCommand("Select " + degisken1 + degisken2 + degisken3 + degisken4 + degisken5 + " from Tbl_DemirbasYazici", yeniBaglanti.baglanti);
                ListeleIki();
            } 
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            Document document = new Document(PageSize.A4, 10, 10, 50, 10);
            PdfWriter pw = PdfWriter.GetInstance(document, new FileStream("C:\\Users\\Sevdanur\\Documents\\Visual Studio 2010\\Projects\\TATBilgiTeknolojileri\\TATBilgiTeknolojileri\\Report\\ReportOfDemirbasYazici.pdf", FileMode.Create));
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

            System.Diagnostics.Process.Start("C:\\Users\\Sevdanur\\Documents\\Visual Studio 2010\\Projects\\TATBilgiTeknolojileri\\TATBilgiTeknolojileri\\Report\\ReportOfDemirbasYazici.pdf");

            ListeyiAktifEt();
        }









    }
}
