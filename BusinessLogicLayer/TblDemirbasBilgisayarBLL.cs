using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TATBilgiTeknolojileri.DataAccessObjects;
using TATBilgiTeknolojileri.PocosLayer;
using System.Data;

namespace TATBilgiTeknolojileri.BusinessLogicLayer
{
    public class TblDemirbasBilgisayarBLL
    {
        private TblDemirbasBilgisayarDAO _TblDemirbasBilgisayarDAO;

        public TblDemirbasBilgisayarBLL()
        {
            _TblDemirbasBilgisayarDAO = new TblDemirbasBilgisayarDAO();
        }


        public TblDemirbasBilgisayarPoco kaydetDemirbasBilgisayar(int id, string deparman, string makinaismi, 
            string kullaniciismi, string kullanicitamismi, string ekran, string mailadresi, string aciklama, 
            string ip, string markamodel, string model, string cpu, string memory, string disc, string aygitcdrw, 
            string sistemreferansno, string ekranreferansno, string sistemyazilimi, string msoffice, 
            string notbilgisi, string yenipcverilistarihi)
        {
            TblDemirbasBilgisayarPoco demirbasBilgisayar = new TblDemirbasBilgisayarPoco();
            DataTable dataTable = new DataTable();

            _TblDemirbasBilgisayarDAO.insertDemirbasBilgisayar(id, deparman, makinaismi, kullaniciismi, 
                kullanicitamismi, ekran, mailadresi, aciklama, ip, markamodel, model, cpu, memory, disc, 
                aygitcdrw, sistemreferansno, ekranreferansno, sistemyazilimi, msoffice, notbilgisi, yenipcverilistarihi);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["id"] = Convert.ToInt32(demirbasBilgisayar.id);
                dr["departman"] = demirbasBilgisayar.departman;
                dr["makinaismi"] = demirbasBilgisayar.makinaismi;
                dr["kullaniciismi"] = demirbasBilgisayar.kullaniciismi;
                dr["kullanicitamismi"] = demirbasBilgisayar.kullanicitamismi;
                dr["ekran"] = demirbasBilgisayar.ekran;
                dr["mailadresi"] = demirbasBilgisayar.mailadresi;
                dr["aciklama"] = demirbasBilgisayar.aciklama;
                dr["ip"] = demirbasBilgisayar.ip;
                dr["markamodel"] = demirbasBilgisayar.markamodel;
                dr["model"] = demirbasBilgisayar.model;
                dr["cpu"] = demirbasBilgisayar.cpu;
                dr["memory"] = demirbasBilgisayar.memory;
                dr["disc"] = demirbasBilgisayar.disc;
                dr["aygitcdrw"] = demirbasBilgisayar.aygitcdrw;
                dr["sistemreferansno"] = demirbasBilgisayar.sistemreferansno;
                dr["ekranreferansno"] = demirbasBilgisayar.ekranreferansno;
                dr["sistemyazilimi"] = demirbasBilgisayar.sistemreferansno;
                dr["msoffice"] = demirbasBilgisayar.msoffice;
                dr["notbilgisi"] = demirbasBilgisayar.notbilgisi;
                dr["yenipcverilistarihi"] = demirbasBilgisayar.yenipcverilistarihi;
              
            }

            return demirbasBilgisayar;
        }

        public TblDemirbasBilgisayarPoco guncelleDemirbasBilgisayar(int id, string deparman, string makinaismi,
            string kullaniciismi, string kullanicitamismi, string ekran, string mailadresi, string aciklama,
            string ip, string markamodel, string model, string cpu, string memory, string disc, string aygitcdrw,
            string sistemreferansno, string ekranreferansno, string sistemyazilimi, string msoffice,
            string notbilgisi, string yenipcverilistarihi)
        {
            TblDemirbasBilgisayarPoco demirbasBilgisayar = new TblDemirbasBilgisayarPoco();
            DataTable dataTable = new DataTable();

            _TblDemirbasBilgisayarDAO.updateDemirbasBilgisayar(id, deparman, makinaismi, kullaniciismi,
                kullanicitamismi, ekran, mailadresi, aciklama, ip, markamodel, model, cpu, memory, disc,
                aygitcdrw, sistemreferansno, ekranreferansno, sistemyazilimi, msoffice, notbilgisi, yenipcverilistarihi);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["departman"] = demirbasBilgisayar.departman;
                dr["makinaismi"] = demirbasBilgisayar.makinaismi;
                dr["kullaniciismi"] = demirbasBilgisayar.kullaniciismi;
                dr["kullanicitamismi"] = demirbasBilgisayar.kullanicitamismi;
                dr["ekran"] = demirbasBilgisayar.ekran;
                dr["mailadresi"] = demirbasBilgisayar.mailadresi;
                dr["aciklama"] = demirbasBilgisayar.aciklama;
                dr["ip"] = demirbasBilgisayar.ip;
                dr["markamodel"] = demirbasBilgisayar.markamodel;
                dr["model"] = demirbasBilgisayar.model;
                dr["cpu"] = demirbasBilgisayar.cpu;
                dr["memory"] = demirbasBilgisayar.memory;
                dr["disc"] = demirbasBilgisayar.disc;
                dr["aygitcdrw"] = demirbasBilgisayar.aygitcdrw;
                dr["sistemreferansno"] = demirbasBilgisayar.sistemreferansno;
                dr["ekranreferansno"] = demirbasBilgisayar.ekranreferansno;
                dr["sistemyazilimi"] = demirbasBilgisayar.sistemreferansno;
                dr["msoffice"] = demirbasBilgisayar.msoffice;
                dr["notbilgisi"] = demirbasBilgisayar.notbilgisi;
                dr["yenipcverilistarihi"] = demirbasBilgisayar.yenipcverilistarihi;

            }

            return demirbasBilgisayar;
        }

        public TblDemirbasBilgisayarPoco silDemirbasBilgisayar(int id)
        {
            TblDemirbasBilgisayarPoco demirbasBilgisayar = new TblDemirbasBilgisayarPoco();
            DataTable dataTable = new DataTable();

            _TblDemirbasBilgisayarDAO.deleteDemirbasBilgisayar(Convert.ToInt32(id));

            return demirbasBilgisayar;
        }
        

    }
}
