using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TATBilgiTeknolojileri.DataAccessObjects;
using TATBilgiTeknolojileri.PocosLayer;
using System.Data;

namespace TATBilgiTeknolojileri.BusinessLogicLayer
{
    public class TblDemirbasScannerBLL
    {

        private TblDemirbasScannerDAO _TblDemirbasScannerDAO;

        public TblDemirbasScannerBLL()
        {
            _TblDemirbasScannerDAO = new TblDemirbasScannerDAO();
        }
         
        public TblDemirbasScannerPoco kaydetDemirbasScanner(int id, string model, string tip,
            string referansno, string departman, string kullanici, string yeniscannerverilistarihi)
        {
            TblDemirbasScannerPoco demirbasScanner = new TblDemirbasScannerPoco();
            DataTable dataTable = new DataTable();

            _TblDemirbasScannerDAO.insertDemirbasScanner(id, model, tip, referansno, departman, kullanici, yeniscannerverilistarihi);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["id"] = Convert.ToInt32(demirbasScanner.id);
                dr["model"] = demirbasScanner.model;
                dr["tip"] = demirbasScanner.tip;
                dr["referansno"] = demirbasScanner.referansno;
                dr["departman"] = demirbasScanner.departman;
                dr["kullanici"] = demirbasScanner.kullanici;
                dr["yeniscannerverilistarihi"] = demirbasScanner.yeniscannerverilistarihi;
            }

            return demirbasScanner;
        }
 
        public TblDemirbasScannerPoco guncelleDemirbasScanner(int id, string model, string tip,
            string referansno, string departman, string kullanici, string yeniscannerverilistarihi)
        {
            TblDemirbasScannerPoco demirbasScanner = new TblDemirbasScannerPoco();
            DataTable dataTable = new DataTable();

            _TblDemirbasScannerDAO.updateDemirbasScanner(id, model, tip, referansno, departman, kullanici, yeniscannerverilistarihi);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["model"] = demirbasScanner.model;
                dr["tip"] = demirbasScanner.tip;
                dr["referansno"] = demirbasScanner.referansno;
                dr["departman"] = demirbasScanner.departman;
                dr["kullanici"] = demirbasScanner.kullanici;
                dr["yeniscannerverilistarihi"] = demirbasScanner.yeniscannerverilistarihi;
            }

            return demirbasScanner;
        }

        public TblDemirbasScannerPoco silDemirbasScanner(int id)   
        {
            TblDemirbasScannerPoco demirbasScanner = new TblDemirbasScannerPoco();
            DataTable dataTable = new DataTable();

            _TblDemirbasScannerDAO.deleteDemirbasScaner(Convert.ToInt32(id));

            return demirbasScanner;
        }
         
          
    }
}
