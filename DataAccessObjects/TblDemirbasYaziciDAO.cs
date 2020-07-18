using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace TATBilgiTeknolojileri.DataAccessObjects
{
    public class TblDemirbasYaziciDAO
    {
        private VeriTabaniBaglantisi baglanti;

        public TblDemirbasYaziciDAO()
        {
            baglanti = new VeriTabaniBaglantisi();
        }
         
        public bool insertDemirbasYazici(int id, string model, string tip, string siyah, string renkli,
            string mavi, string sari, string kirmizi, string departman, string kullanici, string ip, 
            string serino, string aciklama)
        {
            string sorgu = string.Format("insert into Tbl_DemirbasYazici(ID, Model, Tip, Siyah, Renkli, Mavi, Sari, Kirmizi, Departman, Kullanici, Ip, SeriNo, Aciklama) values(@ID, @Model, @Tip, @Siyah, @Renkli, @Mavi, @Sari, @Kirmizi, @Departman, @Kullanici, @Ip, @SeriNo, @Aciklama)");

            SqlParameter[] sqlParameters = new SqlParameter[13];

            sqlParameters[0] = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(id);
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
            sqlParameters[8] = new SqlParameter("@Departman", SqlDbType.NVarChar);
            sqlParameters[8].Value = Convert.ToString(departman);
            sqlParameters[9] = new SqlParameter("@Kullanici", SqlDbType.NVarChar);
            sqlParameters[9].Value = Convert.ToString(kullanici);
            sqlParameters[10] = new SqlParameter("@Ip", SqlDbType.NVarChar);
            sqlParameters[10].Value = Convert.ToString(ip);
            sqlParameters[11] = new SqlParameter("@SeriNo", SqlDbType.NVarChar);
            sqlParameters[11].Value = Convert.ToString(serino); 
            sqlParameters[12] = new SqlParameter("@Aciklama", SqlDbType.NVarChar);
            sqlParameters[12].Value = Convert.ToString(aciklama);

            return baglanti.executeInsertQuery(sorgu, sqlParameters);
        }

        public bool updateDemirbasYazici(int id, string model, string tip, string siyah, string renkli,
            string mavi, string sari, string kirmizi, string departman, string kullanici, string ip,
            string serino, string aciklama)
        {
            string sorgu = string.Format("Update Tbl_DemirbasYazici set Model = @Model, Tip = @Tip, Siyah = @Siyah, Renkli = @Renkli, Mavi = @Mavi, Sari = @Sari, Kirmizi = @Kirmizi, Departman = @Departman, Kullanici = @Kullanici, Ip = @Ip, SeriNo = @SeriNo, Aciklama = @Aciklama where ID = '" + id + "'");

            SqlParameter[] sqlParameters = new SqlParameter[12];

            sqlParameters[0] = new SqlParameter("@Model", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(model);
            sqlParameters[1] = new SqlParameter("@Tip", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(tip);
            sqlParameters[2] = new SqlParameter("@Siyah", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(siyah);
            sqlParameters[3] = new SqlParameter("@Renkli", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(renkli);
            sqlParameters[4] = new SqlParameter("@Mavi", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(mavi);
            sqlParameters[5] = new SqlParameter("@Sari", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(sari);
            sqlParameters[6] = new SqlParameter("@Kirmizi", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(kirmizi);
            sqlParameters[7] = new SqlParameter("@Departman", SqlDbType.NVarChar);
            sqlParameters[7].Value = Convert.ToString(departman);
            sqlParameters[8] = new SqlParameter("@Kullanici", SqlDbType.NVarChar);
            sqlParameters[8].Value = Convert.ToString(kullanici);
            sqlParameters[9] = new SqlParameter("@Ip", SqlDbType.NVarChar);
            sqlParameters[9].Value = Convert.ToString(ip);
            sqlParameters[10] = new SqlParameter("@SeriNo", SqlDbType.NVarChar);
            sqlParameters[10].Value = Convert.ToString(serino);
            sqlParameters[11] = new SqlParameter("@Aciklama", SqlDbType.NVarChar);
            sqlParameters[11].Value = Convert.ToString(aciklama);

            return baglanti.executeUpdateQuery(sorgu, sqlParameters);
        }

        public bool deleteDemirbasYazici(int id)
        {
            string sorgu = string.Format("Delete from Tbl_DemirbasYazici where ID = '" + id + "'");

            return baglanti.executeDeleteQuery(sorgu);
        }
  
    }
}
