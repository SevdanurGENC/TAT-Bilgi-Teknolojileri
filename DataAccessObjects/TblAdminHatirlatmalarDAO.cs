using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace TATBilgiTeknolojileri.DataAccessObjects
{
    public class TblAdminHatirlatmalarDAO
    { 
        private VeriTabaniBaglantisi baglanti;

        public TblAdminHatirlatmalarDAO()
        {
            baglanti = new VeriTabaniBaglantisi();
        }

        public bool insertAdminHatirlatmalar(int id, string yapilacakistanimlari, 
            string tarih)
        {
            string sorgu = string.Format("insert into Tbl_AdminHatirlatmalar(ID, YapilacakIsTanimlari, Tarih) values(@ID, @YapilacakIsTanimlari, @Tarih)");

            SqlParameter[] sqlParameters = new SqlParameter[3];

            sqlParameters[0] = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(id);
            sqlParameters[1] = new SqlParameter("@YapilacakIsTanimlari", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(yapilacakistanimlari);
            sqlParameters[2] = new SqlParameter("@Tarih", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(tarih);
         
            return baglanti.executeInsertQuery(sorgu, sqlParameters);    
        }

        public bool updateAdminHatirlatmalar(int id, string yapilacakistanimlari,
            string tarih, string onay)
        {
            string sorgu = string.Format("Update Tbl_AdminHatirlatmalar set YapilacakIsTanimlari = @YapilacakIsTanimlari, Tarih = @Tarih, Onay = @Onay where ID = '" + id + "'");

            SqlParameter[] sqlParameters = new SqlParameter[3];

            sqlParameters[0] = new SqlParameter("@YapilacakIsTanimlari", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(yapilacakistanimlari);
            sqlParameters[1] = new SqlParameter("@Tarih", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(tarih);
            sqlParameters[2] = new SqlParameter("@Onay", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(onay); 
        
            return baglanti.executeUpdateQuery(sorgu, sqlParameters);
        }

        public bool deleteAdminHatirlatmalar(int id)
        {
            string sorgu = string.Format("Delete from Tbl_AdminHatirlatmalar where ID = '" + id + "'");
             
            return baglanti.executeDeleteQuery(sorgu);
        }
          











    }
}
