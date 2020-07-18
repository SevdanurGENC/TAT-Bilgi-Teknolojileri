using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TATBilgiTeknolojileri.DataAccessObjects;
using TATBilgiTeknolojileri.PocosLayer;
using System.Data;

namespace TATBilgiTeknolojileri.BusinessLogicLayer
{
    public class TblDemirbasYaziciBLL
    {
        private TblDemirbasYaziciDAO _TblDemirbasYaziciDAO;

        public TblDemirbasYaziciBLL()
        {
            _TblDemirbasYaziciDAO = new TblDemirbasYaziciDAO();
        }

        public TblDemirbasYaziciPoco kaydetDemirbasServer(int id, string model, string tip, string siyah,
          string renkli, string mavi, string sari, string kirmizi, string departman, string kullanici,
          string ip, string serino, string aciklama)
        {
            TblDemirbasYaziciPoco demirbasYazici = new TblDemirbasYaziciPoco();
            DataTable dataTable = new DataTable();

            _TblDemirbasYaziciDAO.insertDemirbasYazici(id, model, tip, siyah, renkli, mavi, sari, kirmizi, 
                departman, kullanici, ip, serino, aciklama);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["id"] = Convert.ToInt32(demirbasYazici.id);
                dr["model"] = demirbasYazici.model;
                dr["tip"] = demirbasYazici.tip;
                dr["siyah"] = demirbasYazici.siyah;
                dr["renkli"] = demirbasYazici.renkli;
                dr["mavi"] = demirbasYazici.mavi;
                dr["sari"] = demirbasYazici.sari;
                dr["kirmizi"] = demirbasYazici.kirmizi;
                dr["departman"] = demirbasYazici.departman;
                dr["kullanici"] = demirbasYazici.kullanici;
                dr["ip"] = demirbasYazici.ip;
                dr["serino"] = demirbasYazici.serino;
                dr["aciklama"] = demirbasYazici.aciklama;
            }

            return demirbasYazici;
        }


        public TblDemirbasYaziciPoco guncelleDemirbasServer(int id, string model, string tip, string siyah,
          string renkli, string mavi, string sari, string kirmizi, string departman, string kullanici,
          string ip, string serino, string aciklama)
        {
            TblDemirbasYaziciPoco demirbasYazici = new TblDemirbasYaziciPoco();
            DataTable dataTable = new DataTable();

            _TblDemirbasYaziciDAO.updateDemirbasYazici(id, model, tip, siyah, renkli, mavi, sari, kirmizi,
                departman, kullanici, ip, serino, aciklama);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["model"] = demirbasYazici.model;
                dr["tip"] = demirbasYazici.tip;
                dr["siyah"] = demirbasYazici.siyah;
                dr["renkli"] = demirbasYazici.renkli;
                dr["mavi"] = demirbasYazici.mavi;
                dr["sari"] = demirbasYazici.sari;
                dr["kirmizi"] = demirbasYazici.kirmizi;
                dr["departman"] = demirbasYazici.departman;
                dr["kullanici"] = demirbasYazici.kullanici;
                dr["ip"] = demirbasYazici.ip;
                dr["serino"] = demirbasYazici.serino;
                dr["aciklama"] = demirbasYazici.aciklama;
            }

            return demirbasYazici;
        }


        public TblDemirbasYaziciPoco silDemirbasYazici(int id)
        {
            TblDemirbasYaziciPoco demirbasYazici = new TblDemirbasYaziciPoco();
            DataTable dataTable = new DataTable();

            _TblDemirbasYaziciDAO.deleteDemirbasYazici(Convert.ToInt32(id));

            return demirbasYazici;
        }








    }
}
