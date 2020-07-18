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
    public partial class frmAnaEkran : Form
    {
        private TblAdminHatirlatmalarBLL _TblAdminHatirlatmalarBLL;
        public SqlCommand sorgu;

        public frmAnaEkran()
        {
            InitializeComponent();
            _TblAdminHatirlatmalarBLL = new TblAdminHatirlatmalarBLL();
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

        private void frmAnaEkran_Load(object sender, EventArgs e)
        { 
            VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
            sorgu = new SqlCommand("Select * from Tbl_AdminHatirlatmalar", yeniBaglanti.baglanti);

            Listele();
        }

        private void kullaniciBilgileriGuncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentationLayer.frmKullaniciBilgileriGuncelleme KullaniciGuncellemeEkrani = new frmKullaniciBilgileriGuncelleme();
            KullaniciGuncellemeEkrani.Show();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Application.Exit(); 
        }

        private void satinAlmaYeniIslemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentationLayer.frmSatinAlmaYeniKayitIslemleri SatinAlmaKaydetEkrani = new frmSatinAlmaYeniKayitIslemleri();
            SatinAlmaKaydetEkrani.Show();
        }

        private void satinAlmaBilgiGuncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentationLayer.frmSatinAlmaKayitGuncelleme SatinAlmaGuncellemeEkrani = new frmSatinAlmaKayitGuncelleme();
            SatinAlmaGuncellemeEkrani.Show();
        }

        private void satinAlmaListelemeVeRaporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentationLayer.frmSatinAlmaListelemeVeRaporlama SatinAlmaListelemeRaporEkrani = new frmSatinAlmaListelemeVeRaporlama();
            SatinAlmaListelemeRaporEkrani.Show();
        }

        private void satinAlmaKayitAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentationLayer.frmSatinAlmaKayitSilme SatinAlmaSilmeEkrani = new frmSatinAlmaKayitSilme();
            SatinAlmaSilmeEkrani.Show();
        }

        private void servisTakipListelemeVeRaporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentationLayer.frmServisTakipListelemeVeGuncelleme ServisTakipListelemeRaporEkrani = new frmServisTakipListelemeVeGuncelleme();
            ServisTakipListelemeRaporEkrani.Show();
        }

        private void servisTakipYeniKayitIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentationLayer.frmServisTakipYeniKayitIslemleri ServisTakipYeniKayitEkrani = new frmServisTakipYeniKayitIslemleri();
            ServisTakipYeniKayitEkrani.Show();
        }

        private void servisTakipKayitGuncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentationLayer.frmServisTakipKayitGuncelleme ServisTakipGuncellemeEkrani = new frmServisTakipKayitGuncelleme();
            ServisTakipGuncellemeEkrani.Show();
        }

        private void servisTakipKayitSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentationLayer.frmServisTakipKayitSilme ServisTakipSilmeEkrani = new frmServisTakipKayitSilme();
            ServisTakipSilmeEkrani.Show();
        }

        private void bilgisayarVerilerininHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentationLayer.frmMalzemeBilgisayar MalzemeBilgisayarEkrani = new frmMalzemeBilgisayar();
            MalzemeBilgisayarEkrani.Show();
        }

        private void monitorVerilerininHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentationLayer.frmMalzemeMonitor MalzemeMonitorEkrani = new frmMalzemeMonitor();
            MalzemeMonitorEkrani.Show();
        }

        private void yaziciVerilerininHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentationLayer.frmMalzemeYazici MalzemeYaziciEkrani = new frmMalzemeYazici();
            MalzemeYaziciEkrani.Show();
        }

        private void bilgisayarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentationLayer.frmDemirbasBilgisayarEkrani demirbasBilgisayar = new frmDemirbasBilgisayarEkrani();
            demirbasBilgisayar.Show();
        }

        private void ctosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentationLayer.frmDemirbasCtos demirbasCtos = new frmDemirbasCtos();
            demirbasCtos.Show();
        }

        private void scannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentationLayer.frmDemirbasScanner demirbasScanner = new frmDemirbasScanner();
            demirbasScanner.Show();
        }

        private void serverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentationLayer.frmDemirbasServer demirbasServer = new frmDemirbasServer();
            demirbasServer.Show();
        }

        private void switchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentationLayer.frmDemirbasSwitch demirbasSwitch = new frmDemirbasSwitch();
            demirbasSwitch.Show();
        }

        private void yaziciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentationLayer.frmDemirbasYazici demirbasYazici = new frmDemirbasYazici();
            demirbasYazici.Show();
        }

      
        
        
        
        public string _onayDurumu;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TblAdminHatirlatmalarPoco adminHatirlatmalar = new TblAdminHatirlatmalarPoco();
            adminHatirlatmalar = _TblAdminHatirlatmalarBLL.kaydetAdminHatirlatmalar(Convert.ToInt32(txtID.Text),
                txtGorevTanimlama.Text, txtTarih.Text);

            MessageBox.Show("Kaydiniz Tamamlanmistir...");

            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                _onayDurumu = "Onaylandi";
            else
                _onayDurumu = "Onaylanmadi";

            TblAdminHatirlatmalarPoco adminHatirlatmalar = new TblAdminHatirlatmalarPoco();
            adminHatirlatmalar = _TblAdminHatirlatmalarBLL.guncelleAdminHatirlatmalar(Convert.ToInt32(txtID.Text),
                txtGorevTanimlama.Text, txtTarih.Text, _onayDurumu);

            MessageBox.Show("Guncelleme Isleminiz Tamamlanmistir...");

            Listele();
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                _onayDurumu = "Onaylandi";
            else
                _onayDurumu = "Onaylanmadi";

            TblAdminHatirlatmalarPoco adminHatirlatmalar = new TblAdminHatirlatmalarPoco();
            adminHatirlatmalar = _TblAdminHatirlatmalarBLL.guncelleAdminHatirlatmalar(Convert.ToInt32(txtID.Text),
                txtGorevTanimlama.Text, txtTarih.Text, _onayDurumu);

            MessageBox.Show("Onaylama Isleminiz Tamamlanmistir...");

            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            TblAdminHatirlatmalarPoco adminHatirlatmalar = new TblAdminHatirlatmalarPoco();
            adminHatirlatmalar = _TblAdminHatirlatmalarBLL.silAdminHatirlatmalar(Convert.ToInt32(txtID.Text));

            MessageBox.Show("Silme Isleminiz Tamamlanmistir...");

            Listele();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtGorevTanimlama.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtTarih.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "Onaylandi")
                checkBox1.Checked = true;
            else
                checkBox1.Checked = false;
             
        }

        private void elektronikAtikSirketineGonderileceklerListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentationLayer.frmMalzemeElektronikAtikSirketineTeslimEdilecekler malzemeElektronik = new frmMalzemeElektronikAtikSirketineTeslimEdilecekler();
            malzemeElektronik.Show();

        }

        private void kablosuzWiFiEkipmanlariEkraniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresentationLayer.frmDemirbasKablosuzWifiEkipmanlari demirbasKablosuz = new frmDemirbasKablosuzWifiEkipmanlari();
            demirbasKablosuz.Show();
        }


       
    }
}
