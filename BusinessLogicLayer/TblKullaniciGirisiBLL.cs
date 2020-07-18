using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TATBilgiTeknolojileri.DataAccessObjects;
using TATBilgiTeknolojileri.PocosLayer;
using System.Data;

namespace TATBilgiTeknolojileri.BusinessLogicLayer
{
    public class TblKullaniciGirisiBLL
    {
        private TblKullaniciGirisiDAO _TblKullaniciGirisiDAO;

        public TblKullaniciGirisiBLL()
        {
            _TblKullaniciGirisiDAO = new TblKullaniciGirisiDAO();
        }

        public TblKullaniciGirisiPoco getSorgu(string kullaniciadi, string sifre)  //Kullanici giris ekrani icin tasarlanmis bir metoddur.
        {
            TblKullaniciGirisiPoco kullaniciGirisi = new TblKullaniciGirisiPoco();
            DataTable dataTable = new DataTable();

            dataTable = _TblKullaniciGirisiDAO.searchKullaniciAdiveSifre(kullaniciadi,sifre);

            foreach (DataRow dr in dataTable.Rows)
            {
                kullaniciGirisi.kullaniciadi = dr["kullaniciadi"].ToString();
                kullaniciGirisi.sifre = dr["sifre"].ToString();
            }

            return kullaniciGirisi;
        }

        public TblKullaniciGirisiPoco kaydetKullanici(int id, string kullaniciadi, string sifre, string isim, string soyisim)  //Kullanici listesine yeni bir kayit ekleyen metoddur.
        {
            TblKullaniciGirisiPoco kullaniciGirisi = new TblKullaniciGirisiPoco();
            DataTable dataTable = new DataTable();

            _TblKullaniciGirisiDAO.insertKullanici(id, kullaniciadi, sifre, isim, soyisim);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["id"] = Convert.ToInt32(kullaniciGirisi.id);
                dr["kullaniciadi"] = kullaniciGirisi.kullaniciadi;
                dr["sifre"] = kullaniciGirisi.sifre;
                dr["isim"] = kullaniciGirisi.isim;
                dr["soyisim"] = kullaniciGirisi.soyisim;
            }

            return kullaniciGirisi;
        }

        public TblKullaniciGirisiPoco guncelleKullanici(int id, string kullaniciadi, string sifre, string isim, string soyisim) //Kullanici listesinden secilen bir kaydin bilgilerini guncelleyen metoddur.
        {
            TblKullaniciGirisiPoco kullaniciGirisi = new TblKullaniciGirisiPoco();
            DataTable dataTable = new DataTable();

            _TblKullaniciGirisiDAO.updateKullanici(id, kullaniciadi, sifre, isim, soyisim);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["kullaniciadi"] = kullaniciGirisi.kullaniciadi;
                dr["sifre"] = kullaniciGirisi.sifre;
                dr["isim"] = kullaniciGirisi.isim;
                dr["soyisim"] = kullaniciGirisi.soyisim;
            }

            return kullaniciGirisi;
        }

        public TblKullaniciGirisiPoco silKullanici(int id)   //Kullanici listesinde secilen bir kaydin bilgilerini sistemden tamamen siler.
        {
            TblKullaniciGirisiPoco kullaniciGirisi = new TblKullaniciGirisiPoco();
            DataTable dataTable = new DataTable();

            _TblKullaniciGirisiDAO.deleteKullanici(Convert.ToInt32(id));

            return kullaniciGirisi;
        }
 
    }

  }