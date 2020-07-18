using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TATBilgiTeknolojileri.DataAccessObjects;
using TATBilgiTeknolojileri.PocosLayer;
using System.Data;

namespace TATBilgiTeknolojileri.BusinessLogicLayer
{
    public class TblDemirbasKablosuzWifiEkipmanlariBLL
    {

        private TblDemirbasKablosuzWifiEkipmanlariDAO _TblDemirbasKablosuzWifiEkipmanlariDAO;

         public TblDemirbasKablosuzWifiEkipmanlariBLL()
        {
            _TblDemirbasKablosuzWifiEkipmanlariDAO = new TblDemirbasKablosuzWifiEkipmanlariDAO();
        }

         public TblDemirbasKablosuzWifiEkipmanlariPoco kaydetDemirbasKablosuz(int id, string cihazadi, string aciklama)
        {
            TblDemirbasKablosuzWifiEkipmanlariPoco demirbasKablosuz = new TblDemirbasKablosuzWifiEkipmanlariPoco();
            DataTable dataTable = new DataTable();

            _TblDemirbasKablosuzWifiEkipmanlariDAO.insertDemirbasKablosuz(id, cihazadi, aciklama);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["id"] = Convert.ToInt32(demirbasKablosuz.id);
                dr["cihazadi"] = demirbasKablosuz.cihazadi;
                dr["aciklama"] = demirbasKablosuz.aciklama;               
            }

            return demirbasKablosuz;
        }

         public TblDemirbasKablosuzWifiEkipmanlariPoco guncelleDemirbasKablosuz(int id, string cihazadi, string aciklama)
        {
            TblDemirbasKablosuzWifiEkipmanlariPoco demirbasKablosuz = new TblDemirbasKablosuzWifiEkipmanlariPoco();
            DataTable dataTable = new DataTable();

            _TblDemirbasKablosuzWifiEkipmanlariDAO.updateDemirbasKablosuz(id, cihazadi, aciklama);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["cihazadi"] = demirbasKablosuz.cihazadi;
                dr["aciklama"] = demirbasKablosuz.aciklama;
            }

            return demirbasKablosuz;
        }

         public TblDemirbasKablosuzWifiEkipmanlariPoco silDemirbasKablosuz(int id) 
        {
            TblDemirbasKablosuzWifiEkipmanlariPoco demirbasKablosuz = new TblDemirbasKablosuzWifiEkipmanlariPoco();
            DataTable dataTable = new DataTable();

            _TblDemirbasKablosuzWifiEkipmanlariDAO.deleteDemirbasKablosuz(Convert.ToInt32(id));

            return demirbasKablosuz;
        }
   

    }
}
