using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TATBilgiTeknolojileri.DataAccessObjects;
using TATBilgiTeknolojileri.PocosLayer;
using System.Data;

namespace TATBilgiTeknolojileri.BusinessLogicLayer
{
    public class TblMalzemeMonitorBLL
    { 
        private TblMalzemeMonitorDAO _TblMalzemeMonitorDAO;

        public TblMalzemeMonitorBLL()
        {
            _TblMalzemeMonitorDAO = new TblMalzemeMonitorDAO();
        }

        public TblMalzemeMonitorPoco kaydetMalzemeMonitor(int id, string kullaniciadi, string markamodel, string referansno,
          string sistemserino, string aciklama, string monitordurumu)
        {
            TblMalzemeMonitorPoco malzemeMonitor = new TblMalzemeMonitorPoco();
            DataTable dataTable = new DataTable();

            _TblMalzemeMonitorDAO.insertMalzemeMonitor(id, kullaniciadi, markamodel, referansno, sistemserino, aciklama, monitordurumu);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["id"] = Convert.ToInt32(malzemeMonitor.id);
                dr["kullaniciadi"] = malzemeMonitor.kullaniciAdi;
                dr["markamodel"] = malzemeMonitor.markaModel;
                dr["referansno"] = malzemeMonitor.referansNo;
                dr["sistemserino"] = malzemeMonitor.sistemSeriNo;
                dr["aciklama"] = malzemeMonitor.aciklama;
                dr["monitordurumu"] = malzemeMonitor.monitorDurumu; 
            }

            return malzemeMonitor;
        }

        public TblMalzemeMonitorPoco guncelleMalzemeMonitor(int id, string kullaniciadi, string markamodel, string referansno,
                string sistemserino, string aciklama, string monitordurumu)
        {
            TblMalzemeMonitorPoco malzemeMonitor = new TblMalzemeMonitorPoco();
            DataTable dataTable = new DataTable();

            _TblMalzemeMonitorDAO.updateMalzemeMonitor(id, kullaniciadi, markamodel, referansno, sistemserino, aciklama, monitordurumu);

            foreach (DataRow dr in dataTable.Rows)
            { 
                dr["kullaniciadi"] = malzemeMonitor.kullaniciAdi;
                dr["markamodel"] = malzemeMonitor.markaModel;
                dr["referansno"] = malzemeMonitor.referansNo;
                dr["sistemserino"] = malzemeMonitor.sistemSeriNo;
                dr["aciklama"] = malzemeMonitor.aciklama;
                dr["monitordurumu"] = malzemeMonitor.monitorDurumu;
            }

            return malzemeMonitor;
        }

        public TblMalzemeMonitorPoco silMalzemeMonitor(int id)
        {
            TblMalzemeMonitorPoco malzemeMonitor = new TblMalzemeMonitorPoco();
            DataTable dataTable = new DataTable();

            _TblMalzemeMonitorDAO.deleteMalzemeMonitor(Convert.ToInt32(id));

            return malzemeMonitor;  
        }

    }
}
