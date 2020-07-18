using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace TATBilgiTeknolojileri.DataAccessObjects
{
    public class TblDemirbasCtosDAO
    {
        private VeriTabaniBaglantisi baglanti;

        public TblDemirbasCtosDAO()
        {
            baglanti = new VeriTabaniBaglantisi();
        }

        public bool insertDemirbasCtos(int id, string departman, string model, string marka, string islemci, 
            string bellek, string disc, string sistemreferansno, string ekranreferans)
        {
            string sorgu = string.Format("insert into Tbl_DemirbasCtos(ID, Departman, Model, Marka, Islemci, Bellek, Disc, SistemReferans, EkranReferans) values(@ID, @Departman, @Model, @Marka, @Islemci, @Bellek, @Disc, @SistemReferans, @EkranReferans)");

            SqlParameter[] sqlParameters = new SqlParameter[9];

            sqlParameters[0] = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(id);
            sqlParameters[1] = new SqlParameter("@Departman", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(departman);
            sqlParameters[2] = new SqlParameter("@Model", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(model);
            sqlParameters[3] = new SqlParameter("@Marka", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(marka);
            sqlParameters[4] = new SqlParameter("@Islemci", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(islemci);
            sqlParameters[5] = new SqlParameter("@Bellek", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(bellek);
            sqlParameters[6] = new SqlParameter("@Disc", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(disc);
            sqlParameters[7] = new SqlParameter("@SistemReferans", SqlDbType.NVarChar);
            sqlParameters[7].Value = Convert.ToString(sistemreferansno);
            sqlParameters[8] = new SqlParameter("@EkranReferans", SqlDbType.NVarChar);
            sqlParameters[8].Value = Convert.ToString(ekranreferans);
         
            return baglanti.executeInsertQuery(sorgu, sqlParameters);    
        }

        public bool updateDemirbasCtos(int id, string departman, string model, string marka, string islemci,
            string bellek, string disc, string sistemreferansno, string ekranreferans)
        {
            string sorgu = string.Format("Update Tbl_DemirbasCtos set Departman = @Departman, Model = @Model, Marka = @Marka, Islemci = @Islemci, Bellek = @Bellek, Disc = @Disc, SistemReferans = @SistemReferans, EkranReferans = @EkranReferans where ID = '" + id + "'");

            SqlParameter[] sqlParameters = new SqlParameter[8];
  
            sqlParameters[0] = new SqlParameter("@Departman", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(departman);
            sqlParameters[1] = new SqlParameter("@Model", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(model);
            sqlParameters[2] = new SqlParameter("@Marka", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(marka);
            sqlParameters[3] = new SqlParameter("@Islemci", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(islemci);
            sqlParameters[4] = new SqlParameter("@Bellek", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(bellek);
            sqlParameters[5] = new SqlParameter("@Disc", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(disc);
            sqlParameters[6] = new SqlParameter("@SistemReferans", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(sistemreferansno);
            sqlParameters[7] = new SqlParameter("@EkranReferans", SqlDbType.NVarChar);
            sqlParameters[7].Value = Convert.ToString(ekranreferans);
        
            return baglanti.executeUpdateQuery(sorgu, sqlParameters);
        }

        public bool deleteDemirbasCtos(int id )
        {
            string sorgu = string.Format("Delete from Tbl_DemirbasCtos where ID = '" + id + "'");
             
            return baglanti.executeDeleteQuery(sorgu);
        }
          
    }
}
