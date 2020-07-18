using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TATBilgiTeknolojileri.DataAccessObjects;
using TATBilgiTeknolojileri.PocosLayer;
using System.Data;

namespace TATBilgiTeknolojileri.BusinessLogicLayer
{
    public class TblDemirbasSwitchBLL   
    {
        private TblDemirbasSwitchDAO _TblDemirbasSwitchDAO;

        public TblDemirbasSwitchBLL()
        {
            _TblDemirbasSwitchDAO = new TblDemirbasSwitchDAO();
        }


        public TblDemirbasSwitchPoco kaydetDemirbasSwitch(int id, string bulunduguyer, string marka,
            string aciklama, string ekbilgi)
        {
            TblDemirbasSwitchPoco demirbasSwitch = new TblDemirbasSwitchPoco();
            DataTable dataTable = new DataTable();

            _TblDemirbasSwitchDAO.insertDemirbasSwitch(id, bulunduguyer, marka, aciklama, ekbilgi);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["id"] = Convert.ToInt32(demirbasSwitch.id);
                dr["bulunduguyer"] = demirbasSwitch.bulunduguyer;
                dr["marka"] = demirbasSwitch.marka;
                dr["aciklama"] = demirbasSwitch.aciklama;
                dr["ekbilgi"] = demirbasSwitch.ekbilgi;
            }

            return demirbasSwitch;
        }
         
        public TblDemirbasSwitchPoco guncelleDemirbasSwitch(int id, string bulunduguyer, string marka,
            string aciklama, string ekbilgi)
        {
            TblDemirbasSwitchPoco demirbasSwitch = new TblDemirbasSwitchPoco();
            DataTable dataTable = new DataTable();

            _TblDemirbasSwitchDAO.updateDemirbasSwitch(id, bulunduguyer, marka, aciklama, ekbilgi);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["bulunduguyer"] = demirbasSwitch.bulunduguyer;
                dr["marka"] = demirbasSwitch.marka;
                dr["aciklama"] = demirbasSwitch.aciklama;
                dr["ekbilgi"] = demirbasSwitch.ekbilgi;
            }

            return demirbasSwitch;
        }
          
        public TblDemirbasSwitchPoco silDemirbasServer(int id)
        {
            TblDemirbasSwitchPoco demirbasSwitch = new TblDemirbasSwitchPoco();
            DataTable dataTable = new DataTable();

            _TblDemirbasSwitchDAO.deleteDemirbasSwitch(Convert.ToInt32(id));

            return demirbasSwitch; 
        }
          
    }
}
