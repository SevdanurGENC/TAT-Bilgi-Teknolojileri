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
    public partial class frmKullaniciBilgileriGuncelleme : Form
    {
        private TblKullaniciGirisiBLL _TblKullaniciGirisiBLL;

        public frmKullaniciBilgileriGuncelleme()
        {
            InitializeComponent();
            _TblKullaniciGirisiBLL = new TblKullaniciGirisiBLL();
        }

        private void frmKullaniciBilgileriGuncelleme_Load(object sender, EventArgs e)
        {
            Listele();
        }
 
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TblKullaniciGirisiPoco Kullanici = new TblKullaniciGirisiPoco();
            Kullanici = _TblKullaniciGirisiBLL.kaydetKullanici(Convert.ToInt32(txtID.Text) , txtKullaniciAdi.Text, txtSifre.Text, txtIsim.Text, txtSoyisim.Text);
            MessageBox.Show("Kaydiniz Tamamlanmistir...");
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            TblKullaniciGirisiPoco Kullanici = new TblKullaniciGirisiPoco();
            Kullanici = _TblKullaniciGirisiBLL.guncelleKullanici(Convert.ToInt32(txtID.Text), txtKullaniciAdi.Text, txtSifre.Text, txtIsim.Text, txtSoyisim.Text);
            MessageBox.Show("Guncelleme Islemi Tamamlanmistir...");
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            TblKullaniciGirisiPoco Kullanici = new TblKullaniciGirisiPoco();
            Kullanici = _TblKullaniciGirisiBLL.silKullanici(Convert.ToInt32(txtID.Text));
            MessageBox.Show("Silme Islemi Tamamlanmistir...");
            Listele();
        }

        private void btnGridListele_Click(object sender, EventArgs e)
        {
            Listele();
        }
         
        public void Listele()
        {
            VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();

            SqlCommand sorgu = new SqlCommand("Select * from Tbl_Kullanicilar",yeniBaglanti.baglanti);
            
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);
            adapter.Fill(dataTable);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource; 
        }
    }
}
