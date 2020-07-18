using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TATBilgiTeknolojileri.PocosLayer;
using TATBilgiTeknolojileri.DataAccessObjects;
using System.Data;

namespace TATBilgiTeknolojileri.BusinessLogicLayer
{
    public class TblMalzemeYaziciBLL
    {
        private TblMalzemeYaziciDAO _TblMalzemeYaziciDAO;

        public TblMalzemeYaziciBLL()
        {
            _TblMalzemeYaziciDAO = new TblMalzemeYaziciDAO();        
        }

        public TblMalzemeYaziciPoco kaydetMalzemeYazici(int id, string kullanicidepartman, string model, string tip, string siyah,
            string renkli, string mavi, string sari, string kirmizi, string referansno, string serino,
            string aciklama, string yazicidurumu)
        {
            TblMalzemeYaziciPoco malzemeYazici = new TblMalzemeYaziciPoco();
            DataTable dataTable = new DataTable();

            _TblMalzemeYaziciDAO.insertMalzemeYazici(id, kullanicidepartman, model, tip, siyah, renkli, mavi, sari, kirmizi, referansno, serino, aciklama, yazicidurumu);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["id"] = Convert.ToInt32(malzemeYazici.id);
                dr["kullanicidepartman"] = malzemeYazici.kullaniciDepartman;
                dr["model"] = malzemeYazici.model;
                dr["tip"] = malzemeYazici.tip;
                dr["siyah"] = malzemeYazici.siyah;
                dr["renkli"] = malzemeYazici.renkli;
                dr["mavi"] = malzemeYazici.mavi;
                dr["sari"] = malzemeYazici.sari;
                dr["kirmizi"] = malzemeYazici.kirmizi;
                dr["referansno"] = malzemeYazici.referansNo;
                dr["serino"] = malzemeYazici.seriNo;
                dr["aciklama"] = malzemeYazici.aciklama;
                dr["yazicidurumu"] = malzemeYazici.yaziciDurumu; 
            } 

            return malzemeYazici;
        }
         
        public TblMalzemeYaziciPoco guncelleMalzemeYazici(int id, string kullanicidepartman, string model, string tip, string siyah,
          string renkli, string mavi, string sari, string kirmizi, string referansno, string serino,
          string aciklama, string yazicidurumu)
        {
            TblMalzemeYaziciPoco malzemeYazici = new TblMalzemeYaziciPoco();
            DataTable dataTable = new DataTable();

            _TblMalzemeYaziciDAO.updateMalzemeYazici(id, kullanicidepartman, model, tip, siyah, renkli, mavi, sari, kirmizi, referansno, serino, aciklama, yazicidurumu);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["kullanicidepartman"] = malzemeYazici.kullaniciDepartman;
                dr["model"] = malzemeYazici.model;
                dr["tip"] = malzemeYazici.tip;
                dr["siyah"] = malzemeYazici.siyah;
                dr["renkli"] = malzemeYazici.renkli;
                dr["mavi"] = malzemeYazici.mavi;
                dr["sari"] = malzemeYazici.sari;
                dr["kirmizi"] = malzemeYazici.kirmizi;
                dr["referansno"] = malzemeYazici.referansNo;
                dr["serino"] = malzemeYazici.seriNo;
                dr["aciklama"] = malzemeYazici.aciklama;
                dr["yazicidurumu"] = malzemeYazici.yaziciDurumu;
            }

            return malzemeYazici;
        }

        public TblMalzemeYaziciPoco silMalzemeMonitor(int id)
        {
            TblMalzemeYaziciPoco malzemeYazici = new TblMalzemeYaziciPoco();
            DataTable dataTable = new DataTable();

            _TblMalzemeYaziciDAO.deleteMalzemeYazici(Convert.ToInt32(id));

            return malzemeYazici;
        }

    }
}
