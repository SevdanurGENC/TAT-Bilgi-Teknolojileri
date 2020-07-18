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

namespace TATBilgiTeknolojileri.PresentationLayer
{
    public partial class frmSatinAlmaKayitSilme : Form
    {
        private TblSatinAlmalarBLL _TblSatinAlmalarBLL;

        public frmSatinAlmaKayitSilme()
        {
            InitializeComponent();
            _TblSatinAlmalarBLL = new TblSatinAlmalarBLL();
        }
  
        public void Listele()
        {
            VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();

            SqlCommand sorgu = new SqlCommand("Select * from Tbl_SatinAlmalar", yeniBaglanti.baglanti);

            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);
            adapter.Fill(dataTable);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            TblSatinAlmalarPoco satinAlma = new TblSatinAlmalarPoco();
            satinAlma = _TblSatinAlmalarBLL.silSatinAlma(Convert.ToInt32(txtID.Text));
            MessageBox.Show("Silme Islemi Tamamlanmistir...");

            Listele();            
        }

        private void frmSatinAlmaKayitSilme_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtIsim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtIsletme.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtDepartman.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtIstek.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtIstekTarihi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtKullaniciyaTeslimTarihi.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtRapor.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        } 
    }
}
