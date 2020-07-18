using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace TATBilgiTeknolojileri.DataAccessObjects
{
    public class TblKullaniciGirisiDAO
    {
        private VeriTabaniBaglantisi baglanti;

        public TblKullaniciGirisiDAO()
        {
            baglanti = new VeriTabaniBaglantisi();            
        }

        public DataTable searchKullaniciAdiveSifre(string kullaniciadi, string sifre)   //Kullanici giris ekrani icin tasarlanmis bir metoddur.
        {
            string sorgu = string.Format("Select * from Tbl_Kullanicilar where KullaniciAdi = @KullaniciAdi and Sifre=@Sifre");
            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter("@KullaniciAdi", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(kullaniciadi);
            sqlParameters[1] = new SqlParameter("@Sifre", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(sifre);

            return baglanti.executeSelectQuery(sorgu, sqlParameters);
        }

        public bool insertKullanici(int id, string kullaniciadi, string sifre, string isim, string soyisim)   //Sisteme yeni bir kullanici eklemek icin kullanilan bir metoddur.
        {
            string sorgu = string.Format("insert into Tbl_Kullanicilar(Id,KullaniciAdi,Sifre,Isim,Soyisim) values(@Id, @KullaniciAdi,@Sifre,@Isim,@Soyisim)");

            SqlParameter[] sqlParameters = new SqlParameter[5];

            sqlParameters[0] = new SqlParameter("@KullaniciAdi", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(kullaniciadi);
            sqlParameters[1] = new SqlParameter("@Sifre", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(sifre);
            sqlParameters[2] = new SqlParameter("@Isim", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(isim);
            sqlParameters[3] = new SqlParameter("@Soyisim", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(soyisim);
            sqlParameters[4] = new SqlParameter("@Id", SqlDbType.Int);
            sqlParameters[4].Value = Convert.ToInt32(id);

            return baglanti.executeInsertQuery(sorgu, sqlParameters);
        }

        public bool updateKullanici(int id, string kullaniciadi, string sifre, string isim, string soyisim)  //sistemdeki secilen bir kullanicinin bilgilerini guncelleyen metoddur.
        {
            string sorgu = string.Format("update Tbl_Kullanicilar set KullaniciAdi = @KullaniciAdi, Sifre = @Sifre, Isim = @Isim, Soyisim = @Soyisim where id = '" + id + "'");

            SqlParameter[] sqlParameters = new SqlParameter[4];

            sqlParameters[0] = new SqlParameter("@Sifre", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(sifre);
            sqlParameters[1] = new SqlParameter("@Isim", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(isim);
            sqlParameters[2] = new SqlParameter("@Soyisim", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(soyisim);
            sqlParameters[3] = new SqlParameter("@KullaniciAdi", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(kullaniciadi);

            return baglanti.executeUpdateQuery(sorgu, sqlParameters);
        }  

        public bool deleteKullanici(int id) //sistemden secilen kullaniciyi silen metoddur..
        {
            string sorgu = string.Format("Delete from Tbl_Kullanicilar where Id = '" + id + "'");

            return baglanti.executeDeleteQuery(sorgu);
        }   
  
    }
}
