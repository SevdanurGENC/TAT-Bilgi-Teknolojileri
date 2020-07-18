using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace TATBilgiTeknolojileri.DataAccessObjects
{
    public class TblDemirbasServerDAO
    {
        private VeriTabaniBaglantisi baglanti;

        public TblDemirbasServerDAO()
        {
            baglanti = new VeriTabaniBaglantisi();
        }
         
        public bool insertDemirbasServer(int id, string departman, string serveradi, string ip, string marka, string model, string cpu,
            string memory, string disc, string aygitcdrw, string sistemreferansno, string ekranreferans, string sistemyazilimi)
        {
            string sorgu = string.Format("insert into Tbl_DemirbasServer(ID, Departman, ServerAdi, Ip, Marka, Model, Cpu, Memory, Disc, AygitCdRw, SistemReferansNo, EkranReferans, SistemYazilimi) values(@ID, @Departman, @ServerAdi, @Ip, @Marka, @Model, @Cpu, @Memory, @Disc, @AygitCdRw, @SistemReferansNo, @EkranReferans, @SistemYazilimi)");

            SqlParameter[] sqlParameters = new SqlParameter[13];

            sqlParameters[0] = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(id);
            sqlParameters[1] = new SqlParameter("@Departman", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(departman);
            sqlParameters[2] = new SqlParameter("@ServerAdi", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(serveradi);
            sqlParameters[3] = new SqlParameter("@Ip", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(ip);
            sqlParameters[4] = new SqlParameter("@Marka", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(marka);
            sqlParameters[5] = new SqlParameter("@Model", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(model);
            sqlParameters[6] = new SqlParameter("@Cpu", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(cpu);
            sqlParameters[7] = new SqlParameter("@Memory", SqlDbType.NVarChar);
            sqlParameters[7].Value = Convert.ToString(memory);
            sqlParameters[8] = new SqlParameter("@Disc", SqlDbType.NVarChar);
            sqlParameters[8].Value = Convert.ToString(disc); 
            sqlParameters[9] = new SqlParameter("@AygitCdRw", SqlDbType.NVarChar);
            sqlParameters[9].Value = Convert.ToString(aygitcdrw);
            sqlParameters[10] = new SqlParameter("@SistemReferansNo", SqlDbType.NVarChar);
            sqlParameters[10].Value = Convert.ToString(sistemreferansno);
            sqlParameters[11] = new SqlParameter("@EkranReferans", SqlDbType.NVarChar);
            sqlParameters[11].Value = Convert.ToString(ekranreferans);
            sqlParameters[12] = new SqlParameter("@SistemYazilimi", SqlDbType.NVarChar);
            sqlParameters[12].Value = Convert.ToString(sistemyazilimi);
             
            return baglanti.executeInsertQuery(sorgu, sqlParameters);
        }

        public bool updateDemirbasServer(int id, string departman, string serveradi, string ip, string marka, string model, string cpu,
            string memory, string disc, string aygitcdrw, string sistemreferansno, string ekranreferans, string sistemyazilimi)
        {
            string sorgu = string.Format("Update Tbl_DemirbasServer set Departman = @Departman, ServerAdi = @ServerAdi, Ip = @Ip, Marka = @Marka, Model = @Model, Cpu = @Cpu, Memory = @Memory, Disc = @Disc, AygitCdRw = @AygitCdRw, SistemReferansNo = @SistemReferansNo, EkranReferans = @EkranReferans, SistemYazilimi = @SistemYazilimi where ID = '" + id + "'");

            SqlParameter[] sqlParameters = new SqlParameter[12];

            sqlParameters[0] = new SqlParameter("@Departman", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(departman);
            sqlParameters[1] = new SqlParameter("@ServerAdi", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(serveradi);
            sqlParameters[2] = new SqlParameter("@Ip", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(ip);
            sqlParameters[3] = new SqlParameter("@Marka", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(marka);
            sqlParameters[4] = new SqlParameter("@Model", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(model);
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
            sqlParameters[10] = new SqlParameter("@EkranReferans", SqlDbType.NVarChar);
            sqlParameters[10].Value = Convert.ToString(ekranreferans);
            sqlParameters[11] = new SqlParameter("@SistemYazilimi", SqlDbType.NVarChar);
            sqlParameters[11].Value = Convert.ToString(sistemyazilimi);

            return baglanti.executeUpdateQuery(sorgu, sqlParameters);
        }

        public bool deleteDemirbasServer(int id)
        {
            string sorgu = string.Format("Delete from Tbl_DemirbasServer where ID = '" + id + "'");

            return baglanti.executeDeleteQuery(sorgu);
        }
          
    }
}
