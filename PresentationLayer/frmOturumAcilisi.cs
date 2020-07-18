using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using TATBilgiTeknolojileri.BusinessLogicLayer;
using TATBilgiTeknolojileri.PocosLayer;

namespace TATBilgiTeknolojileri
{
    public partial class frmOturumAcilisi : Form
    {
        private TblKullaniciGirisiBLL _TblKullaniciGirisiBLL;

        public frmOturumAcilisi()
        {
            InitializeComponent();
            _TblKullaniciGirisiBLL = new TblKullaniciGirisiBLL();
        }

     
        private void btnSistemeGiris_Click(object sender, EventArgs e)
        {
            TblKullaniciGirisiPoco _TblKullaniciGirisiPoco = new TblKullaniciGirisiPoco();
            _TblKullaniciGirisiPoco = _TblKullaniciGirisiBLL.getSorgu(txtKullaniciAdi.Text, txtSifre.Text);

            if ((_TblKullaniciGirisiPoco.kullaniciadi == null) || (_TblKullaniciGirisiPoco.sifre == null))
                MessageBox.Show("Hatali Giris Yaptiniz...");
            else
            {
                this.Hide();
                MessageBox.Show("Hos Geldiniz, " + _TblKullaniciGirisiPoco.kullaniciadi);
                PresentationLayer.frmAnaEkran girisEkrani = new PresentationLayer.frmAnaEkran();
                girisEkrani.Show();               
            }
        }
    }
}
