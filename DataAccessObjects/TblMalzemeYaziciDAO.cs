using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace TATBilgiTeknolojileri.DataAccessObjects
{
    public class TblMalzemeYaziciDAO
    {
        private VeriTabaniBaglantisi baglanti;

        public TblMalzemeYaziciDAO()
        {
            baglanti = new VeriTabaniBaglantisi();
        }

        public bool insertMalzemeYazici(int id, string kullanicidepartman, string model, string tip, string siyah,
            string renkli, string mavi, string sari, string kirmizi, string referansno, string serino,
            string aciklama, string yazicidurumu)
        {
            string sorgu = string.Format("insert into Tbl_MalzemeYazici(ID, KullaniciDepartman, Model, Tip, Siyah, Renkli, Mavi, Sari, Kirmizi, ReferansNo, SeriNo, Aciklama, YaziciDurumu) values(@ID, @KullaniciDepartman, @Model, @Tip, @Siyah, @Renkli, @Mavi, @Sari, @Kirmizi, @ReferansNo, @SeriNo, @Aciklama, @YaziciDurumu)");

            SqlParameter[] sqlParameters = new SqlParameter[13];

            sqlParameters[0] = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(id);
            sqlParameters[1] = new SqlParameter("@KullaniciDepartman", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(kullanicidepartman);
            sqlParameters[2] = new SqlParameter("@Model", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(model);
            sqlParameters[3] = new SqlParameter("@Tip", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(tip);
            sqlParameters[4] = new SqlParameter("@Siyah", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(siyah);
            sqlParameters[5] = new SqlParameter("@Renkli", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(renkli);
            sqlParameters[6] = new SqlParameter("@Mavi", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(mavi);
            sqlParameters[7] = new SqlParameter("@Sari", SqlDbType.NVarChar);
            sqlParameters[7].Value = Convert.ToString(sari);
            sqlParameters[8] = new SqlParameter("@Kirmizi", SqlDbType.NVarChar);
            sqlParameters[8].Value = Convert.ToString(kirmizi);
            sqlParameters[9] = new SqlParameter("@ReferansNo", SqlDbType.NVarChar);
            sqlParameters[9].Value = Convert.ToString(referansno);
            sqlParameters[10] = new SqlParameter("@SeriNo", SqlDbType.NVarChar);
            sqlParameters[10].Value = Convert.ToString(serino);
            sqlParameters[11] = new SqlParameter("@Aciklama", SqlDbType.NVarChar);
            sqlParameters[11].Value = Convert.ToString(aciklama);
            sqlParameters[12] = new SqlParameter("@YaziciDurumu", SqlDbType.NVarChar);
            sqlParameters[12].Value = Convert.ToString(yazicidurumu);

            return baglanti.executeInsertQuery(sorgu, sqlParameters);
        }


        public bool updateMalzemeYazici(int id, string kullanicidepartman, string model, string tip, string siyah,
            string renkli, string mavi, string sari, string kirmizi, string referansno, string serino,
            string aciklama, string yazicidurumu)
        {
            string sorgu = string.Format("update Tbl_MalzemeYazici set KullaniciDepartman = @KullaniciDepartman, Model = @Model, Tip = @Tip, Siyah = @Siyah, Renkli = @Renkli, Mavi = @Mavi, Sari = @Sari, Kirmizi = @Kirmizi, ReferansNo = @ReferansNo, SeriNo = @SeriNo, Aciklama = @Aciklama, YaziciDurumu = @YaziciDurumu where ID = '" + id + "'");

            SqlParameter[] sqlParameters = new SqlParameter[12];

            sqlParameters[0] = new SqlParameter("@KullaniciDepartman", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(kullanicidepartman);
            sqlParameters[1] = new SqlParameter("@Model", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(model);
            sqlParameters[2] = new SqlParameter("@Tip", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(tip);
            sqlParameters[3] = new SqlParameter("@Siyah", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(siyah);
            sqlParameters[4] = new SqlParameter("@Renkli", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(renkli);
            sqlParameters[5] = new SqlParameter("@Mavi", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(mavi);
            sqlParameters[6] = new SqlParameter("@Sari", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(sari);
            sqlParameters[7] = new SqlParameter("@Kirmizi", SqlDbType.NVarChar);
            sqlParameters[7].Value = Convert.ToString(kirmizi);
            sqlParameters[8] = new SqlParameter("@ReferansNo", SqlDbType.NVarChar);
            sqlParameters[8].Value = Convert.ToString(referansno);
            sqlParameters[9] = new SqlParameter("@SeriNo", SqlDbType.NVarChar);
            sqlParameters[9].Value = Convert.ToString(serino);
            sqlParameters[10] = new SqlParameter("@Aciklama", SqlDbType.NVarChar);
            sqlParameters[10].Value = Convert.ToString(aciklama);
            sqlParameters[11] = new SqlParameter("@YaziciDurumu", SqlDbType.NVarChar);
            sqlParameters[11].Value = Convert.ToString(yazicidurumu);

            return baglanti.executeUpdateQuery(sorgu, sqlParameters);
        }


        public bool deleteMalzemeYazici(int id)
        {
            string sorgu = string.Format("Delete From Tbl_MalzemeYazici where ID = '" + id + "'");
            return baglanti.executeDeleteQuery(sorgu);
         }


    }
}
