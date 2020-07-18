using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace TATBilgiTeknolojileri.DataAccessObjects
{
    public class TblMalzemeElektronikAtikSirketineTeslimEdileceklerDAO
    {
        private VeriTabaniBaglantisi baglanti;

        public TblMalzemeElektronikAtikSirketineTeslimEdileceklerDAO()
        {
            baglanti = new VeriTabaniBaglantisi();
        }

        public bool insertMalzemeElektronik(int id, string kullaniciadi, string markamodel,
            string referansno, string sistemserino, string aciklama, string durumu)
        {
            string sorgu = string.Format("insert into Tbl_MalzemeElektronikAtikSirketineTeslimEdilecekler(ID, KullaniciAdi, MarkaModel, ReferansNo, SistemSeriNo, Aciklama, Durumu) values(@ID, @KullaniciAdi, @MarkaModel, @ReferansNo, @SistemSeriNo, @Aciklama, @Durumu)");

            SqlParameter[] sqlParameters = new SqlParameter[7];

            sqlParameters[0] = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(id);
            sqlParameters[1] = new SqlParameter("@KullaniciAdi", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(kullaniciadi);
            sqlParameters[2] = new SqlParameter("@MarkaModel", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(markamodel);
            sqlParameters[3] = new SqlParameter("@ReferansNo", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(referansno);
            sqlParameters[4] = new SqlParameter("@SistemSeriNo", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(sistemserino);
            sqlParameters[5] = new SqlParameter("@Aciklama", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(aciklama);
            sqlParameters[6] = new SqlParameter("@Durumu", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(durumu);
         
            return baglanti.executeInsertQuery(sorgu, sqlParameters);    
        }

        public bool updateMalzemeElektronik(int id, string kullaniciadi, string markamodel,
            string referansno, string sistemserino, string aciklama, string durumu)
        {
            string sorgu = string.Format("Update Tbl_MalzemeElektronikAtikSirketineTeslimEdilecekler set KullaniciAdi = @KullaniciAdi, MarkaModel = @MarkaModel, ReferansNo = @ReferansNo, SistemSeriNo = @SistemSeriNo, Aciklama = @Aciklama, Durumu = @Durumu where ID = '" + id + "'");

            SqlParameter[] sqlParameters = new SqlParameter[6];
  
            sqlParameters[0] = new SqlParameter("@KullaniciAdi", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(kullaniciadi);
            sqlParameters[1] = new SqlParameter("@MarkaModel", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(markamodel);
            sqlParameters[2] = new SqlParameter("@ReferansNo", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(referansno);
            sqlParameters[3] = new SqlParameter("@SistemSeriNo", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(sistemserino);
            sqlParameters[4] = new SqlParameter("@Aciklama", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(aciklama);
            sqlParameters[5] = new SqlParameter("@Durumu", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(durumu);
         
        
            return baglanti.executeUpdateQuery(sorgu, sqlParameters);
        }

        public bool deleteMalzemeElektronik(int id)
        {
            string sorgu = string.Format("Delete from Tbl_MalzemeElektronikAtikSirketineTeslimEdilecekler where ID = '" + id + "'");
             
            return baglanti.executeDeleteQuery(sorgu);
        }
          














    }
}
