using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace TATBilgiTeknolojileri.DataAccessObjects
{
    public class TblDemirbasSwitchDAO
    {
        private VeriTabaniBaglantisi baglanti;

        public TblDemirbasSwitchDAO()
        {
            baglanti = new VeriTabaniBaglantisi();
        }


   public bool insertDemirbasSwitch(int id, string bulunduguyer, string marka, string aciklama, string ekbilgi)
        {
            string sorgu = string.Format("Insert into Tbl_DemirbasSwitch(ID, BulunduguYer, Marka, Aciklama, EkBilgi) values(@ID, @BulunduguYer, @Marka, @Aciklama, @EkBilgi)");

            SqlParameter[] sqlParameters = new SqlParameter[5];

            sqlParameters[0] = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(id);
            sqlParameters[1] = new SqlParameter("@BulunduguYer", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(bulunduguyer);
            sqlParameters[2] = new SqlParameter("@Marka", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(marka);
            sqlParameters[3] = new SqlParameter("@Aciklama", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(aciklama);
            sqlParameters[4] = new SqlParameter("@EkBilgi", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(ekbilgi);
         

            return baglanti.executeInsertQuery(sorgu, sqlParameters);
        }

   public bool updateDemirbasSwitch(int id, string bulunduguyer, string marka, string aciklama, string ekbilgi)
        {
            string sorgu = string.Format("Update Tbl_DemirbasSwitch set BulunduguYer = @BulunduguYer, Marka = @Marka, Aciklama = @Aciklama, EkBilgi = @EkBilgi where ID = '" + id + "'");

            SqlParameter[] sqlParameters = new SqlParameter[4];

            sqlParameters[0] = new SqlParameter("@BulunduguYer", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(bulunduguyer);
            sqlParameters[1] = new SqlParameter("@Marka", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(marka);
            sqlParameters[2] = new SqlParameter("@Aciklama", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(aciklama);
            sqlParameters[3] = new SqlParameter("@EkBilgi", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(ekbilgi);

            return baglanti.executeUpdateQuery(sorgu, sqlParameters);
        }

   public bool deleteDemirbasSwitch(int id)
        {
            string sorgu = string.Format("Delete from Tbl_DemirbasSwitch where ID = '" + id + "'");

            return baglanti.executeDeleteQuery(sorgu);
        }
          

    }
}
