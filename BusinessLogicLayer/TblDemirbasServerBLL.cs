using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TATBilgiTeknolojileri.DataAccessObjects;
using TATBilgiTeknolojileri.PocosLayer;
using System.Data;

namespace TATBilgiTeknolojileri.BusinessLogicLayer
{
    public class TblDemirbasServerBLL
    { 
        private TblDemirbasServerDAO _TblDemirbasServerDAO;

        public TblDemirbasServerBLL()
        {
            _TblDemirbasServerDAO = new TblDemirbasServerDAO();
        }


        public TblDemirbasServerPoco kaydetDemirbasServer(int id, string departman, string serveradi, string ip,
            string marka, string model, string cpu, string memory, string disc, string aygitcdrw, 
            string sistemreferansno, string ekranreferans, string sistemyazilimi)
        {
            TblDemirbasServerPoco demirbasServer = new TblDemirbasServerPoco();
            DataTable dataTable = new DataTable();

            _TblDemirbasServerDAO.insertDemirbasServer(id, departman, serveradi, ip, marka, model, 
                cpu, memory, disc, aygitcdrw, sistemreferansno, ekranreferans, sistemyazilimi);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["id"] = Convert.ToInt32(demirbasServer.id);
                dr["departman"] = demirbasServer.departman;
                dr["serveradi"] = demirbasServer.serveradi;
                dr["ip"] = demirbasServer.ip;
                dr["marka"] = demirbasServer.marka;
                dr["model"] = demirbasServer.model;
                dr["cpu"] = demirbasServer.cpu;
                dr["memory"] = demirbasServer.memory;
                dr["disc"] = demirbasServer.disc;
                dr["aygitcdrw"] = demirbasServer.aygitcdrw;
                dr["sistemreferansno"] = demirbasServer.sistemreferansno;
                dr["ekranreferans"] = demirbasServer.ekranreferans;
                dr["sistemyazilimi"] = demirbasServer.sistemyazilimi; 
            }

            return demirbasServer;
        }

         
         public TblDemirbasServerPoco guncelleDemirbasServer(int id, string departman, string serveradi, string ip,
            string marka, string model, string cpu, string memory, string disc, string aygitcdrw, 
            string sistemreferansno, string ekranreferans, string sistemyazilimi)
        {
            TblDemirbasServerPoco demirbasServer = new TblDemirbasServerPoco();
            DataTable dataTable = new DataTable();

            _TblDemirbasServerDAO.updateDemirbasServer(id, departman, serveradi, ip, marka, model, 
                cpu, memory, disc, aygitcdrw, sistemreferansno, ekranreferans, sistemyazilimi);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["departman"] = demirbasServer.departman;
                dr["serveradi"] = demirbasServer.serveradi;
                dr["ip"] = demirbasServer.ip;
                dr["marka"] = demirbasServer.marka;
                dr["model"] = demirbasServer.model;
                dr["cpu"] = demirbasServer.cpu;
                dr["memory"] = demirbasServer.memory;
                dr["disc"] = demirbasServer.disc;
                dr["aygitcdrw"] = demirbasServer.aygitcdrw;
                dr["sistemreferansno"] = demirbasServer.sistemreferansno;
                dr["ekranreferans"] = demirbasServer.ekranreferans;
                dr["sistemyazilimi"] = demirbasServer.sistemyazilimi; 
            }

            return demirbasServer;
        }
         
          public TblDemirbasServerPoco silDemirbasServer(int id)
          {
              TblDemirbasServerPoco demirbasServer = new TblDemirbasServerPoco();
              DataTable dataTable = new DataTable();

              _TblDemirbasServerDAO.deleteDemirbasServer(Convert.ToInt32(id));
             
              return demirbasServer;
          
          }

         
    }
}
