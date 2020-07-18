using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace TATBilgiTeknolojileri.DataAccessObjects
{
    public class TblDemirbasScannerDAO
    {

        private VeriTabaniBaglantisi baglanti;

        public TblDemirbasScannerDAO()
        {
            baglanti = new VeriTabaniBaglantisi();
        }


        public bool insertDemirbasScanner(int id, string model, string tip, string referansno,
            string departman, string kullanici, string yeniscannerverilistarihi)
        {
            string sorgu = string.Format("insert into Tbl_DemirbasScanner(ID, Model, Tip, ReferansNo, Departman, Kullanici, YeniScannerVerilisTarihi) values(@ID, @Model, @Tip, @ReferansNo, @Departman, @Kullanici, @YeniScannerVerilisTarihi)");

            SqlParameter[] sqlParameters = new SqlParameter[7];

            sqlParameters[0] = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(id);
            sqlParameters[1] = new SqlParameter("@Model", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(model);
            sqlParameters[2] = new SqlParameter("@Tip", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(tip);
            sqlParameters[3] = new SqlParameter("@ReferansNo", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(referansno);
            sqlParameters[4] = new SqlParameter("@Departman", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(departman);
            sqlParameters[5] = new SqlParameter("@Kullanici", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(kullanici);
            sqlParameters[6] = new SqlParameter("@YeniScannerVerilisTarihi", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(yeniscannerverilistarihi);

            return baglanti.executeInsertQuery(sorgu, sqlParameters);
        }

        public bool updateDemirbasScanner(int id, string model, string tip, string referansno,
            string departman, string kullanici, string yeniscannerverilistarihi)
        {
            string sorgu = string.Format("Update Tbl_DemirbasScanner set Model = @Model, Tip = @Tip, ReferansNo = @ReferansNo, Departman = @Departman, Kullanici = @Kullanici, YeniScannerVerilisTarihi = @YeniScannerVerilisTarihi where ID = '" + id + "'");

            SqlParameter[] sqlParameters = new SqlParameter[6];

            sqlParameters[0] = new SqlParameter("@Model", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(model);
            sqlParameters[1] = new SqlParameter("@Tip", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(tip);
            sqlParameters[2] = new SqlParameter("@ReferansNo", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(referansno);
            sqlParameters[3] = new SqlParameter("@Departman", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(departman);
            sqlParameters[4] = new SqlParameter("@Kullanici", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(kullanici);
            sqlParameters[5] = new SqlParameter("@YeniScannerVerilisTarihi", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(yeniscannerverilistarihi);

            return baglanti.executeUpdateQuery(sorgu, sqlParameters);
        }

        public bool deleteDemirbasScaner(int id)
        {
            string sorgu = string.Format("Delete from Tbl_DemirbasScanner where ID = '" + id + "'");

            return baglanti.executeDeleteQuery(sorgu);
        }
         

    }
}
