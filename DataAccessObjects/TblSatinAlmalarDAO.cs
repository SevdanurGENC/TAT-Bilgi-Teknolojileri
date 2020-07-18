using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace TATBilgiTeknolojileri.DataAccessObjects
{
    public class TblSatinAlmalarDAO
    {
        private VeriTabaniBaglantisi baglanti;

        public TblSatinAlmalarDAO()
        {
            baglanti = new VeriTabaniBaglantisi();
        }

        public bool insertSatinAlma(int id, string isim, string soyisim, string isletme, string departman,
            string istek, string istektarihi, string kullaniciyateslimtarihi, string rapor)

        {
            string sorgu = string.Format("insert into Tbl_SatinAlmalar(ID, Isim, Soyisim, Isletme, Departman, Istek, IstekTarihi, KullaniciyaTeslimTarihi, Rapor) values(@ID, @Isim, @Soyisim, @Isletme, @Departman, @Istek, @IstekTarihi, @KullaniciyaTeslimTarihi, @Rapor)");

            SqlParameter[] sqlParameters = new SqlParameter[9];

            sqlParameters[0] = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(id);
            sqlParameters[1] = new SqlParameter("@Isim", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(isim);
            sqlParameters[2] = new SqlParameter("@Soyisim", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(soyisim);
            sqlParameters[3] = new SqlParameter("@Isletme", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(isletme);
            sqlParameters[4] = new SqlParameter("@Departman", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(departman);
            sqlParameters[5] = new SqlParameter("@Istek", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(istek);
            sqlParameters[6] = new SqlParameter("@IstekTarihi", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(istektarihi);
            sqlParameters[7] = new SqlParameter("@KullaniciyaTeslimTarihi", SqlDbType.NVarChar);
            sqlParameters[7].Value = Convert.ToString(kullaniciyateslimtarihi);
            sqlParameters[8] = new SqlParameter("@Rapor", SqlDbType.NVarChar);
            sqlParameters[8].Value = Convert.ToString(rapor);
            
            return baglanti.executeInsertQuery(sorgu, sqlParameters);
        }

        public bool updateSatinAlma(int id, string isim, string soyisim, string isletme, string departman,
           string istek, string istektarihi, string kullaniciyateslimtarihi, string rapor)
        {
            string sorgu = string.Format("update Tbl_SatinAlmalar set Isim = @Isim, Soyisim = @Soyisim, Isletme = @Isletme, Departman = @Departman, Istek = @istek, IstekTarihi = @IstekTarihi, KullaniciyaTeslimTarihi = @KullaniciyaTeslimTarihi where ID = '" + id + "'");
            
            SqlParameter[] sqlParameters = new SqlParameter[8];

            sqlParameters[0] = new SqlParameter("@Isim", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(isim);
            sqlParameters[1] = new SqlParameter("@Soyisim", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(soyisim);
            sqlParameters[2] = new SqlParameter("@Isletme", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(isletme);
            sqlParameters[3] = new SqlParameter("@Departman", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(departman);
            sqlParameters[4] = new SqlParameter("@Istek", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(istek);
            sqlParameters[5] = new SqlParameter("@IstekTarihi", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(istektarihi);
            sqlParameters[6] = new SqlParameter("@KullaniciyaTeslimTarihi", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(kullaniciyateslimtarihi);
            sqlParameters[7] = new SqlParameter("@Rapor", SqlDbType.NVarChar);
            sqlParameters[7].Value = Convert.ToString(rapor);

            return baglanti.executeUpdateQuery(sorgu, sqlParameters);
        }

        public bool deleteSatinAlma(int id) //sistemden secilen kullaniciyi silen metoddur..
        {
            string sorgu = string.Format("Delete from Tbl_SatinAlmalar where Id = '" + id + "'");

            return baglanti.executeDeleteQuery(sorgu);
        }  

    }
}
