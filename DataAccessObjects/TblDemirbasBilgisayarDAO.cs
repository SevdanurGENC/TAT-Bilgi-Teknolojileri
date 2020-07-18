using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace TATBilgiTeknolojileri.DataAccessObjects
{
    public class TblDemirbasBilgisayarDAO
    { 
        private VeriTabaniBaglantisi baglanti;

        public TblDemirbasBilgisayarDAO()
        {
            baglanti = new VeriTabaniBaglantisi();
        }


        public bool insertDemirbasBilgisayar(int id, string deparman, string makinaismi, string kullaniciismi, 
            string kullanicitamismi, string ekran, string mailadresi, string aciklama, string ip, 
            string markamodel, string model, string cpu, string memory, string disc, string aygitcdrw,
            string sistemreferansno, string ekranreferansno, string sistemyazilimi, string msoffice,
            string notbilgisi, string yenipcverilistarihi)
        {
            string sorgu = string.Format("Insert into Tbl_DemirbasBilgisayar(ID, Departman, MakinaIsmi, KullaniciIsmi, KullaniciTamIsmi, Ekran, MailAdresi, Aciklama, Ip, MarkaModel, Model, Cpu, Memory, Disc, AygitCdRw, SistemReferansNo, EkranReferansNo, SistemYazilimi, MsOffice, NotBilgisi, YeniPcVerilisTarihi) values(@ID, @Departman, @MakinaIsmi, @KullaniciIsmi, @KullaniciTamIsmi, @Ekran, @MailAdresi, @Aciklama, @Ip, @MarkaModel, @Model, @Cpu, @Memory, @Disc, @AygitCdRw, @SistemReferansNo, @EkranReferansNo, @SistemYazilimi, @MsOffice, @NotBilgisi, @YeniPcVerilisTarihi)");

            SqlParameter[] sqlParameters = new SqlParameter[21];

            sqlParameters[0] = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(id);
            sqlParameters[1] = new SqlParameter("@Departman", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(deparman);
            sqlParameters[2] = new SqlParameter("@MakinaIsmi", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(makinaismi);
            sqlParameters[3] = new SqlParameter("@KullaniciIsmi", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(kullaniciismi);
            sqlParameters[4] = new SqlParameter("@KullaniciTamIsmi", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(kullanicitamismi);
            sqlParameters[5] = new SqlParameter("@Ekran", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(ekran);
            sqlParameters[6] = new SqlParameter("@MailAdresi", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(mailadresi);
            sqlParameters[7] = new SqlParameter("@Aciklama", SqlDbType.NVarChar);
            sqlParameters[7].Value = Convert.ToString(aciklama);
            sqlParameters[8] = new SqlParameter("@Ip", SqlDbType.NVarChar);
            sqlParameters[8].Value = Convert.ToString(ip);
            sqlParameters[9] = new SqlParameter("@MarkaModel", SqlDbType.NVarChar);
            sqlParameters[9].Value = Convert.ToString(markamodel);
            sqlParameters[10] = new SqlParameter("@Model", SqlDbType.NVarChar);
            sqlParameters[10].Value = Convert.ToString(model);
            sqlParameters[11] = new SqlParameter("@Cpu", SqlDbType.NVarChar);
            sqlParameters[11].Value = Convert.ToString(cpu);
            sqlParameters[12] = new SqlParameter("@Memory", SqlDbType.NVarChar);
            sqlParameters[12].Value = Convert.ToString(memory);
            sqlParameters[13] = new SqlParameter("@Disc", SqlDbType.NVarChar);
            sqlParameters[13].Value = Convert.ToString(disc);
            sqlParameters[14] = new SqlParameter("@AygitCdRw", SqlDbType.NVarChar);
            sqlParameters[14].Value = Convert.ToString(aygitcdrw);
            sqlParameters[15] = new SqlParameter("@SistemReferansNo", SqlDbType.NVarChar);
            sqlParameters[15].Value = Convert.ToString(sistemreferansno);
            sqlParameters[16] = new SqlParameter("@EkranReferansNo", SqlDbType.NVarChar);
            sqlParameters[16].Value = Convert.ToString(ekranreferansno);
            sqlParameters[17] = new SqlParameter("@SistemYazilimi", SqlDbType.NVarChar);
            sqlParameters[17].Value = Convert.ToString(sistemyazilimi);
            sqlParameters[18] = new SqlParameter("@MsOffice", SqlDbType.NVarChar);
            sqlParameters[18].Value = Convert.ToString(msoffice);
            sqlParameters[19] = new SqlParameter("@NotBilgisi", SqlDbType.NVarChar);
            sqlParameters[19].Value = Convert.ToString(notbilgisi);
            sqlParameters[20] = new SqlParameter("@YeniPcVerilisTarihi", SqlDbType.NVarChar);
            sqlParameters[20].Value = Convert.ToString(yenipcverilistarihi);
   
            return baglanti.executeInsertQuery(sorgu, sqlParameters);
        }

        public bool updateDemirbasBilgisayar(int id, string deparman, string makinaismi, string kullaniciismi, 
            string kullanicitamismi, string ekran, string mailadresi, string aciklama, string ip, 
            string markamodel, string model, string cpu, string memory, string disc, string aygitcdrw,
            string sistemreferansno, string ekranreferansno, string sistemyazilimi, string msoffice,
            string notbilgisi, string yenipcverilistarihi)
        {
            string sorgu = string.Format("Update Tbl_DemirbasBilgisayar set Departman = @Departman, MakinaIsmi = @MakinaIsmi, KullaniciIsmi = @KullaniciIsmi, KullaniciTamIsmi = @KullaniciTamIsmi, Ekran = @Ekran, MailAdresi = @MailAdresi, Aciklama = @Aciklama, Ip = @Ip, MarkaModel = @MarkaModel, Model = @Model, Cpu = @Cpu, Memory = @Memory, Disc = @Disc, AygitCdRw = @AygitCdRw, SistemReferansNo = @SistemReferansNo, EkranReferansNo = @EkranReferansNo, SistemYazilimi = @SistemYazilimi, MsOffice = @MsOffice, NotBilgisi = @NotBilgisi, YeniPcVerilisTarihi = @YeniPcVerilisTarihi where ID = '" + id + "'");

            SqlParameter[] sqlParameters = new SqlParameter[20];
 
            sqlParameters[0] = new SqlParameter("@Departman", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(deparman);
            sqlParameters[1] = new SqlParameter("@MakinaIsmi", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(makinaismi);
            sqlParameters[2] = new SqlParameter("@KullaniciIsmi", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(kullaniciismi);
            sqlParameters[3] = new SqlParameter("@KullaniciTamIsmi", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(kullanicitamismi);
            sqlParameters[4] = new SqlParameter("@Ekran", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(ekran);
            sqlParameters[5] = new SqlParameter("@MailAdresi", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(mailadresi);
            sqlParameters[6] = new SqlParameter("@Aciklama", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(aciklama);
            sqlParameters[7] = new SqlParameter("@Ip", SqlDbType.NVarChar);
            sqlParameters[7].Value = Convert.ToString(ip);
            sqlParameters[8] = new SqlParameter("@MarkaModel", SqlDbType.NVarChar);
            sqlParameters[8].Value = Convert.ToString(markamodel);
            sqlParameters[9] = new SqlParameter("@Model", SqlDbType.NVarChar);
            sqlParameters[9].Value = Convert.ToString(model);
            sqlParameters[10] = new SqlParameter("@Cpu", SqlDbType.NVarChar);
            sqlParameters[10].Value = Convert.ToString(cpu);
            sqlParameters[11] = new SqlParameter("@Memory", SqlDbType.NVarChar);
            sqlParameters[11].Value = Convert.ToString(memory);
            sqlParameters[12] = new SqlParameter("@Disc", SqlDbType.NVarChar);
            sqlParameters[12].Value = Convert.ToString(disc);
            sqlParameters[13] = new SqlParameter("@AygitCdRw", SqlDbType.NVarChar);
            sqlParameters[13].Value = Convert.ToString(aygitcdrw);
            sqlParameters[14] = new SqlParameter("@SistemReferansNo", SqlDbType.NVarChar);
            sqlParameters[14].Value = Convert.ToString(sistemreferansno);
            sqlParameters[15] = new SqlParameter("@EkranReferansNo", SqlDbType.NVarChar);
            sqlParameters[15].Value = Convert.ToString(ekranreferansno);
            sqlParameters[16] = new SqlParameter("@SistemYazilimi", SqlDbType.NVarChar);
            sqlParameters[16].Value = Convert.ToString(sistemyazilimi);
            sqlParameters[17] = new SqlParameter("@MsOffice", SqlDbType.NVarChar);
            sqlParameters[17].Value = Convert.ToString(msoffice);
            sqlParameters[18] = new SqlParameter("@NotBilgisi", SqlDbType.NVarChar);
            sqlParameters[18].Value = Convert.ToString(notbilgisi);
            sqlParameters[19] = new SqlParameter("@YeniPcVerilisTarihi", SqlDbType.NVarChar);
            sqlParameters[19].Value = Convert.ToString(yenipcverilistarihi);

            return baglanti.executeUpdateQuery(sorgu, sqlParameters);
        }

        public bool deleteDemirbasBilgisayar(int id)
        {
            string sorgu = string.Format("Delete from Tbl_DemirbasBilgisayar where ID = '" + id + "'");

            return baglanti.executeDeleteQuery(sorgu);
        }

         
    }
}
