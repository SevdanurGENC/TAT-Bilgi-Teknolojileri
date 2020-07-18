using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TATBilgiTeknolojileri.DataAccessObjects;
using TATBilgiTeknolojileri.PocosLayer;
using System.Data;

namespace TATBilgiTeknolojileri.BusinessLogicLayer
{
    public class TblMalzemeBilgisayarBLL
    {
        private TblMalzemeBilgisayarDAO _TblMalzemeBilgisayarDAO;

        public TblMalzemeBilgisayarBLL()
        {
            _TblMalzemeBilgisayarDAO = new TblMalzemeBilgisayarDAO();
        }
         
        public TblMalzemeBilgisayarPoco kaydetMalzemeBilgisayar(int id, string departman, string kullaniciismi, string kullanicitamismi,
            string markamodel, string cpu, string memory, string disc, string aygitcdrw, string sistemreferansno,
            string sistemyazilimi, string msoffice, string aciklama)
        {
            TblMalzemeBilgisayarPoco malzemeBilgisayar = new TblMalzemeBilgisayarPoco();
            DataTable dataTable = new DataTable();

            _TblMalzemeBilgisayarDAO.insertMalzemeBilgisayar(id, departman, kullaniciismi, kullanicitamismi, markamodel, cpu, memory, disc, 
                aygitcdrw, sistemreferansno, sistemyazilimi, msoffice, aciklama);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["id"] = Convert.ToInt32(malzemeBilgisayar.id);
                dr["departman"] = malzemeBilgisayar.departman;
                dr["kullaniciismi"] = malzemeBilgisayar.kullaniciIsmi;
                dr["kullanicitamismi"] = malzemeBilgisayar.kullaniciTamIsmi;
                dr["markamodel"] = malzemeBilgisayar.markaModel;
                dr["cpu"] = malzemeBilgisayar.cpu;
                dr["memory"] = malzemeBilgisayar.memory;
                dr["disc"] = malzemeBilgisayar.disc;
                dr["aygitcdrw"] = malzemeBilgisayar.aygitCdRw;
                dr["sistemreferansno"] = malzemeBilgisayar.sistemReferansNo;
                dr["sistemyazilimi"] = malzemeBilgisayar.sistemYazilimi;
                dr["msoffice"] = malzemeBilgisayar.msOffice;
                dr["aciklama"] = malzemeBilgisayar.aciklama;
            }

            return malzemeBilgisayar;
        }
 
        public TblMalzemeBilgisayarPoco guncelleMalzemeBilgisayar(int id, string departman, string kullaniciismi, string kullanicitamismi,
            string markamodel, string cpu, string memory, string disc, string aygitcdrw, string sistemreferansno,
            string sistemyazilimi, string msoffice, string aciklama)
        {
            TblMalzemeBilgisayarPoco malzemeBilgisayar = new TblMalzemeBilgisayarPoco();
            DataTable dataTable = new DataTable();

            _TblMalzemeBilgisayarDAO.updateMalzemeBilgisayar(id, departman, kullaniciismi, kullanicitamismi, markamodel, cpu, memory, disc,
                aygitcdrw, sistemreferansno, sistemyazilimi, msoffice, aciklama);

            foreach (DataRow dr in dataTable.Rows)
            { 
                dr["departman"] = malzemeBilgisayar.departman;
                dr["kullaniciismi"] = malzemeBilgisayar.kullaniciIsmi;
                dr["kullanicitamismi"] = malzemeBilgisayar.kullaniciTamIsmi;
                dr["markamodel"] = malzemeBilgisayar.markaModel;
                dr["cpu"] = malzemeBilgisayar.cpu;
                dr["memory"] = malzemeBilgisayar.memory;
                dr["disc"] = malzemeBilgisayar.disc;
                dr["aygitcdrw"] = malzemeBilgisayar.aygitCdRw;
                dr["sistemreferansno"] = malzemeBilgisayar.sistemReferansNo;
                dr["sistemyazilimi"] = malzemeBilgisayar.sistemYazilimi;
                dr["msoffice"] = malzemeBilgisayar.msOffice;
                dr["aciklama"] = malzemeBilgisayar.aciklama;
            }

            return malzemeBilgisayar;
        }
         
        public TblMalzemeBilgisayarPoco silMalzemeBilgisayar(int id)   //Kullanici listesinde secilen bir kaydin bilgilerini sistemden tamamen siler.
        {
            TblMalzemeBilgisayarPoco malzemeBilgisayar = new TblMalzemeBilgisayarPoco();
            DataTable dataTable = new DataTable();

            _TblMalzemeBilgisayarDAO.deleteMalzemeBilgisayar(Convert.ToInt32(id));

            return malzemeBilgisayar;
        }
         
    }
}
