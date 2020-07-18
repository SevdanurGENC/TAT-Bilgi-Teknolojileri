using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace TATBilgiTeknolojileri.DataAccessObjects
{
    public class TblMalzemeBilgisayarDAO
    {
        private VeriTabaniBaglantisi baglanti;

        public TblMalzemeBilgisayarDAO()
        {
            baglanti = new VeriTabaniBaglantisi();
        }

        public bool insertMalzemeBilgisayar(int id, string departman, string kullaniciismi, string kullanicitamismi,
            string markamodel, string cpu, string memory, string disc, string aygitcdrw, string sistemreferansno,
            string sistemyazilimi, string msoffice, string aciklama)
        {
            string sorgu = string.Format("insert into Tbl_MalzemeBilgisayar(ID, Departman, KullaniciIsmi, KullaniciTamIsmi, MarkaModel, Cpu, Memory, Disc, AygitCdRw, SistemReferansNo, SistemYazilimi, MsOffice, Aciklama) values(@ID, @Departman, @KullaniciIsmi, @KullaniciTamIsmi, @MarkaModel, @Cpu, @Memory, @Disc, @AygitCdRw, @SistemReferansNo, @SistemYazilimi, @MsOffice, @Aciklama)");

            SqlParameter[] sqlParameters = new SqlParameter[13];

            sqlParameters[0] = new SqlParameter("@Id", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(id);
            sqlParameters[1] = new SqlParameter("@Departman", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(departman);
            sqlParameters[2] = new SqlParameter("@KullaniciIsmi", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(kullaniciismi);
            sqlParameters[3] = new SqlParameter("@KullaniciTamIsmi", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(kullanicitamismi);
            sqlParameters[4] = new SqlParameter("@MarkaModel", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(markamodel);
            sqlParameters[5] = new SqlParameter("@Cpu", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(cpu);
            sqlParameters[6] = new SqlParameter("@Memory", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(memory);
            sqlParameters[7] = new SqlParameter("@Disc", SqlDbType.NVarChar);
            sqlParameters[7].Value = Convert.ToString(disc);
            sqlParameters[8] = new SqlParameter("@AygitCdRw", SqlDbType.NVarChar);
            sqlParameters[8].Value = Convert.ToString(aygitcdrw);
            sqlParameters[9] = new SqlParameter("@SistemReferansNo", SqlDbType.NVarChar);
            sqlParameters[9].Value = Convert.ToString(sistemreferansno);
            sqlParameters[10] = new SqlParameter("@SistemYazilimi", SqlDbType.NVarChar);
            sqlParameters[10].Value = Convert.ToString(sistemyazilimi);
            sqlParameters[11] = new SqlParameter("@MsOffice", SqlDbType.NVarChar);
            sqlParameters[11].Value = Convert.ToString(msoffice);
            sqlParameters[12] = new SqlParameter("@Aciklama", SqlDbType.NVarChar);
            sqlParameters[12].Value = Convert.ToString(aciklama);

            return baglanti.executeInsertQuery(sorgu, sqlParameters);
        }

        public bool updateMalzemeBilgisayar(int id, string departman, string kullaniciismi, string kullanicitamismi,
                  string markamodel, string cpu, string memory, string disc, string aygitcdrw, string sistemreferansno,
                  string sistemyazilimi, string msoffice, string aciklama)
        {
            string sorgu = string.Format("update Tbl_MalzemeBilgisayar set Departman = @Departman, KullaniciIsmi = @KullaniciIsmi, KullaniciTamIsmi = @KullaniciTamIsmi, MarkaModel = @MarkaModel, Cpu = @Cpu, Memory = @Memory, Disc = @Disc, AygitCdRw = @AygitCdRw , SistemReferansNo = @SistemReferansNo, SistemYazilimi = @SistemYazilimi, MsOffice = @MsOffice, Aciklama = @Aciklama where ID = '" + id + "'");

            SqlParameter[] sqlParameters = new SqlParameter[12];

            sqlParameters[0] = new SqlParameter("@Departman", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(departman);
            sqlParameters[1] = new SqlParameter("@KullaniciIsmi", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(kullaniciismi);
            sqlParameters[2] = new SqlParameter("@KullaniciTamIsmi", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(kullanicitamismi);
            sqlParameters[3] = new SqlParameter("@MarkaModel", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(markamodel);
            sqlParameters[4] = new SqlParameter("@Cpu", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(cpu);
            sqlParameters[5] = new SqlParameter("@Memory", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(memory);
            sqlParameters[6] = new SqlParameter("@Disc", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(disc);
            sqlParameters[7] = new SqlParameter("@AygitCdRw", SqlDbType.NVarChar);
            sqlParameters[7].Value = Convert.ToString(aygitcdrw);
            sqlParameters[8] = new SqlParameter("@SistemReferansNo", SqlDbType.NVarChar);
            sqlParameters[8].Value = Convert.ToString(sistemreferansno);
            sqlParameters[9] = new SqlParameter("@SistemYazilimi", SqlDbType.NVarChar);
            sqlParameters[9].Value = Convert.ToString(sistemyazilimi);
            sqlParameters[10] = new SqlParameter("@MsOffice", SqlDbType.NVarChar);
            sqlParameters[10].Value = Convert.ToString(msoffice);
            sqlParameters[11] = new SqlParameter("@Aciklama", SqlDbType.NVarChar);
            sqlParameters[11].Value = Convert.ToString(aciklama);

            return baglanti.executeInsertQuery(sorgu, sqlParameters);
        }
         
        public bool deleteMalzemeBilgisayar(int id)
        {
            string sorgu = string.Format("Delete From Tbl_MalzemeBilgisayar where ID = '" + id + "'");

            return baglanti.executeDeleteQuery(sorgu);
        }

    }
}
