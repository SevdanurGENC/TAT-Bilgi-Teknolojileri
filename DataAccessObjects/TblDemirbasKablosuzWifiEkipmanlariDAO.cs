using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace TATBilgiTeknolojileri.DataAccessObjects
{
    public class TblDemirbasKablosuzWifiEkipmanlariDAO
    {
        private VeriTabaniBaglantisi baglanti;

        public TblDemirbasKablosuzWifiEkipmanlariDAO()
        {
            baglanti = new VeriTabaniBaglantisi();
        }

        public bool insertDemirbasKablosuz(int id, string cihazadi, string aciklama)
        {
            string sorgu = string.Format("Insert into Tbl_DemirbasKablosuzWifiEkipmanlari(ID, CihazAdi, Aciklama) values(@ID, @CihazAdi, @Aciklama)");

            SqlParameter[] sqlParameters = new SqlParameter[3];

            sqlParameters[0] = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(id);
            sqlParameters[1] = new SqlParameter("@CihazAdi", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(cihazadi);
            sqlParameters[2] = new SqlParameter("@Aciklama", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(aciklama);
           
            return baglanti.executeInsertQuery(sorgu, sqlParameters);
        }

        public bool updateDemirbasKablosuz(int id, string cihazadi, string aciklama)
        {
            string sorgu = string.Format("Update Tbl_DemirbasKablosuzWifiEkipmanlari set CihazAdi = @CihazAdi, Aciklama = @Aciklama where ID = '" + id + "'");

            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter("@CihazAdi", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(cihazadi);
            sqlParameters[1] = new SqlParameter("@Aciklama", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(aciklama);
             
            return baglanti.executeUpdateQuery(sorgu, sqlParameters);
        }

        public bool deleteDemirbasKablosuz(int id)
        {
            string sorgu = string.Format("Delete from Tbl_DemirbasKablosuzWifiEkipmanlari where ID = '" + id + "'");

            return baglanti.executeDeleteQuery(sorgu);
        }




    }
}
