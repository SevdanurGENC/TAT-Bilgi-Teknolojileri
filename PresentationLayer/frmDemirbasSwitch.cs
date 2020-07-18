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
    public partial class frmDemirbasSwitch : Form
    {
        private TblDemirbasSwitchBLL _TblDemirbasSwitchBLL;
        public SqlCommand sorgu;

        public frmDemirbasSwitch()
        {
            InitializeComponent();
            _TblDemirbasSwitchBLL = new TblDemirbasSwitchBLL();
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

        private void frmDemirbasSwitch_Load(object sender, EventArgs e)
        {
            ListeyiAktifEt();

            VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
            sorgu = new SqlCommand("Select * from Tbl_DemirbasSwitch", yeniBaglanti.baglanti);

            Listele();

            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false; 
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TblDemirbasSwitchPoco DemirbasSwitch = new TblDemirbasSwitchPoco();
            DemirbasSwitch = _TblDemirbasSwitchBLL.kaydetDemirbasSwitch(Convert.ToInt32(txtID.Text),
                txtBulunduguYer.Text, txtMarka.Text, txtAciklama.Text, txtEkBilgi.Text);

            MessageBox.Show("Kaydiniz Tamamlanmistir...");
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            TblDemirbasSwitchPoco DemirbasSwitch = new TblDemirbasSwitchPoco();
            DemirbasSwitch = _TblDemirbasSwitchBLL.guncelleDemirbasSwitch(Convert.ToInt32(txtID.Text),
                txtBulunduguYer.Text, txtMarka.Text, txtAciklama.Text, txtEkBilgi.Text);

            MessageBox.Show("Guncelleme Isleminiz Tamamlanmistir...");
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            TblDemirbasSwitchPoco DemirbasSwitch = new TblDemirbasSwitchPoco();
            DemirbasSwitch = _TblDemirbasSwitchBLL.silDemirbasServer(Convert.ToInt32(txtID.Text));
            MessageBox.Show("Silme Isleminiz Tamamlanmistir...");
            Listele();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false; 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBulunduguYer.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtMarka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtEkBilgi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        public string degisken1;
        public string degisken2;
        public string degisken3;

        private void btnListele_Click(object sender, EventArgs e)
        {
            ListeyiPasifYap();

            if (radioButton1.Checked == true)
            {
                VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
                sorgu = new SqlCommand("Select * from Tbl_DemirbasSwitch", yeniBaglanti.baglanti);
                ListeleIki();
            }

            if (radioButton2.Checked == true)
            {
                if (checkBox1.Checked == true)
                    degisken1 = "BulunduguYer,";
                else
                    degisken1 = "";

                if (checkBox2.Checked == true)
                    degisken2 = "Marka,";
                else
                    degisken2 = "";

                if (checkBox3.Checked == true)
                    degisken3 = "Aciklama, EkBilgi";
                else
                    degisken3 = "";
 

                VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
                sorgu = new SqlCommand("Select " + degisken1 + degisken2 + degisken3 + " from Tbl_DemirbasSwitch", yeniBaglanti.baglanti);
                ListeleIki();
            } 
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            Document document = new Document(PageSize.A4, 10, 10, 50, 10);
            PdfWriter pw = PdfWriter.GetInstance(document, new FileStream("C:\\Users\\Sevdanur\\Documents\\Visual Studio 2010\\Projects\\TATBilgiTeknolojileri\\TATBilgiTeknolojileri\\Report\\ReportOfDemirbasSwitch.pdf", FileMode.Create));
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

            System.Diagnostics.Process.Start("C:\\Users\\Sevdanur\\Documents\\Visual Studio 2010\\Projects\\TATBilgiTeknolojileri\\TATBilgiTeknolojileri\\Report\\ReportOfDemirbasSwitch.pdf");

            ListeyiAktifEt();
        }
         
    }
}
