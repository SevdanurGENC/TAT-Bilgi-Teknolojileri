using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace TATBilgiTeknolojileri.DataAccessObjects
{
    public class TblMalzemeMonitorDAO
    {
        private VeriTabaniBaglantisi baglanti;

        public TblMalzemeMonitorDAO()
        {
            baglanti = new VeriTabaniBaglantisi();
        }

        public bool insertMalzemeMonitor(int id, string kullaniciadi, string markamodel, string referansno,
          string sistemserino, string aciklama, string monitordurumu)
        {
            string sorgu = string.Format("insert into Tbl_MalzemeMonitor(ID, KullaniciAdi, MarkaModel, ReferansNo, SistemSeriNo, Aciklama, MonitorDurumu) values(@ID, @KullaniciAdi, @MarkaModel, @ReferansNo, @SistemSeriNo, @Aciklama, @MonitorDurumu)");

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
            sqlParameters[6] = new SqlParameter("@MonitorDurumu", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(monitordurumu);
              
            return baglanti.executeInsertQuery(sorgu, sqlParameters);
        }

        public bool updateMalzemeMonitor(int id, string kullaniciadi, string markamodel, string referansno,
          string sistemserino, string aciklama, string monitordurumu)
        {
            string sorgu = string.Format("update Tbl_MalzemeMonitor set KullaniciAdi = @KullaniciAdi, MarkaModel = @MarkaModel, ReferansNo = @ReferansNo, SistemSeriNo = @SistemSeriNo, Aciklama = @Aciklama, MonitorDurumu = @MonitorDurumu where ID = '" + id + "'");

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
            sqlParameters[6] = new SqlParameter("@MonitorDurumu", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(monitordurumu);

            return baglanti.executeUpdateQuery(sorgu, sqlParameters);
        }


        public bool deleteMalzemeMonitor(int id)
        { 
            string sorgu = string.Format("Delete From Tbl_MalzemeMonitor where ID = '" + id + "'");
            return baglanti.executeDeleteQuery(sorgu);
        }

         
    }
}
