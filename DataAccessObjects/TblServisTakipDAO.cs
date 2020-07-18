using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TATBilgiTeknolojileri.DataAccessObjects
{
    public class TblServisTakipDAO
    {
        private VeriTabaniBaglantisi baglanti;

        public TblServisTakipDAO()
        {
            baglanti = new VeriTabaniBaglantisi();

        }

        public bool insertServisTakip(int id, string markamodel, string referansno, string ilgilidepartmankisi,
            string aciklama, string onarim, string ilgilifirma, string gonderilistarihi, string alinistarihi, string sonuc)
        {
            string sorgu = string.Format("insert into Tbl_ServisTakip(ID, MarkaModel, ReferansNo, IlgiliDepartmanKisi, Aciklama, Onarim, IlgiliFirma, GonderilisTarihi, AlinisTarihi, Sonuc) values(@ID, @MarkaModel, @ReferansNo, @IlgiliDepartmanKisi, @Aciklama, @Onarim, @IlgiliFirma, @GonderilisTarihi, @AlinisTarihi, @Sonuc)");
            
            SqlParameter[] sqlParameters = new SqlParameter[10];

            sqlParameters[0] = new SqlParameter("ID", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(id);
            sqlParameters[1] = new SqlParameter("MarkaModel", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(markamodel);
            sqlParameters[2] = new SqlParameter("ReferansNo", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(referansno);
            sqlParameters[3] = new SqlParameter("IlgiliDepartmanKisi", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(ilgilidepartmankisi);
            sqlParameters[4] = new SqlParameter("Aciklama", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(aciklama);
            sqlParameters[5] = new SqlParameter("Onarim", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(onarim);
            sqlParameters[6] = new SqlParameter("IlgiliFirma", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(ilgilifirma);
            sqlParameters[7] = new SqlParameter("GonderilisTarihi", SqlDbType.NVarChar);
            sqlParameters[7].Value = Convert.ToString(gonderilistarihi);
            sqlParameters[8] = new SqlParameter("AlinisTarihi", SqlDbType.NVarChar);
            sqlParameters[8].Value = Convert.ToString(alinistarihi);
            sqlParameters[9] = new SqlParameter("Sonuc", SqlDbType.NVarChar);
            sqlParameters[9].Value = Convert.ToString(sonuc);

            return baglanti.executeInsertQuery(sorgu, sqlParameters);      
        
        }


        public bool updateServisTakip(int id, string markamodel, string referansno, string ilgilidepartmankisi,
                   string aciklama, string onarim, string ilgilifirma, string gonderilistarihi, string alinistarihi, string sonuc)
        {
            string sorgu = string.Format("update Tbl_ServisTakip set MarkaModel = @MarkaModel, ReferansNo = @ReferansNo, IlgiliDepartmanKisi = @IlgiliDepartmanKisi, Aciklama = @Aciklama, Onarim = @Onarim, IlgiliFirma = @IlgiliFirma, GonderilisTarihi = @GonderilisTarihi, AlinisTarihi = @AlinisTarihi, Sonuc = @Sonuc where ID = '" + id + "'");

            SqlParameter[] sqlParameters = new SqlParameter[9];

            sqlParameters[0] = new SqlParameter("MarkaModel", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(markamodel);
            sqlParameters[1] = new SqlParameter("ReferansNo", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(referansno);
            sqlParameters[2] = new SqlParameter("IlgiliDepartmanKisi", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(ilgilidepartmankisi);
            sqlParameters[3] = new SqlParameter("Aciklama", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(aciklama);
            sqlParameters[4] = new SqlParameter("Onarim", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(onarim);
            sqlParameters[5] = new SqlParameter("IlgiliFirma", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(ilgilifirma);            
            sqlParameters[6] = new SqlParameter("GonderilisTarihi", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(gonderilistarihi);
            sqlParameters[7] = new SqlParameter("AlinisTarihi", SqlDbType.NVarChar);
            sqlParameters[7].Value = Convert.ToString(alinistarihi);
            sqlParameters[8] = new SqlParameter("Sonuc", SqlDbType.NVarChar);
            sqlParameters[8].Value = Convert.ToString(sonuc);

            return baglanti.executeUpdateQuery(sorgu, sqlParameters);

        }


        public bool deleteServisTakip(int id) //sistemden secilen kullaniciyi silen metoddur..
        {
            string sorgu = string.Format("Delete from Tbl_ServisTakip where ID = '" + id + "'");

            return baglanti.executeDeleteQuery(sorgu);
        }   

    }
}
