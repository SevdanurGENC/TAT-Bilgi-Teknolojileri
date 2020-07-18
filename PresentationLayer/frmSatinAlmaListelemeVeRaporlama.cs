using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace TATBilgiTeknolojileri.PresentationLayer
{
    public partial class frmSatinAlmaListelemeVeRaporlama : Form
    {
        public frmSatinAlmaListelemeVeRaporlama()
        {
            InitializeComponent();
        }

        public SqlCommand sorgu;

        private void frmSatinAlmaListelemeVeRaporlama_Load(object sender, EventArgs e)
        {
            VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
            sorgu = new SqlCommand("Select * from Tbl_SatinAlmalar", yeniBaglanti.baglanti);
             
            Listele();
 
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
        }

        public void Listele()
        {
         
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);
            adapter.Fill(dataTable);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
        }

        public string degisken1;
        public string degisken2;
        public string degisken3;
        public string degisken4;
        public string degisken5;

        private void btnListele_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
                sorgu = new SqlCommand("Select * from Tbl_SatinAlmalar", yeniBaglanti.baglanti);
                Listele();
            }
            if (radioButton2.Checked == true)
            {
                if (checkBox1.Checked == true)
                    degisken1 = "Isim,Soyisim,";
                else
                    degisken1 = "";
                
                if (checkBox2.Checked == true)
                    degisken2 = "Isletme,";
                else
                    degisken2 = "";

                if (checkBox3.Checked == true)
                    degisken3 = "Departman,";
                else
                    degisken3 = "";

                if (checkBox4.Checked == true)
                    degisken4 = "Istek,";
                else
                    degisken4 = "";

                if (checkBox5.Checked == true)
                    degisken5 = "IstekTarihi,KullaniciyaTeslimTarihi,Rapor";
                else
                    degisken5 = "";

                VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
                sorgu = new SqlCommand("Select "+ degisken1 + degisken2 + degisken3 + degisken4 + degisken5 + " from Tbl_SatinAlmalar", yeniBaglanti.baglanti);
                Listele();
            } 
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            Document document = new Document(PageSize.A4, 10, 10, 50, 10);
            PdfWriter pw = PdfWriter.GetInstance(document, new FileStream("C:\\Users\\Sevdanur\\Documents\\Visual Studio 2010\\Projects\\TATBilgiTeknolojileri\\TATBilgiTeknolojileri\\Report\\ReportOfSatinAlma.pdf", FileMode.Create));
            document.Open();

            PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                table.AddCell(new Phrase(dataGridView1.Columns[j].HeaderText));
            }

            table.HeaderRows = 1;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int k = 0; k < dataGridView1.Columns.Count; k++)
                {
                    if (dataGridView1[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(dataGridView1[k,i].Value.ToString()));
                    }
                }
            }

            document.Add(table);
            document.Close();

            System.Diagnostics.Process.Start("C:\\Users\\Sevdanur\\Documents\\Visual Studio 2010\\Projects\\TATBilgiTeknolojileri\\TATBilgiTeknolojileri\\Report\\ReportOfSatinAlma.pdf");
        }

      
       
    }
}
