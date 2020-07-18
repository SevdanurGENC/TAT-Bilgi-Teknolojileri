using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TATBilgiTeknolojileri.DataAccessObjects;
using TATBilgiTeknolojileri.PocosLayer;
using System.Data;

namespace TATBilgiTeknolojileri.BusinessLogicLayer
{
    public class TblDemirbasCtosBLL
    { 
        private TblDemirbasCtosDAO _TblDemirbasCtosDAO;

        public TblDemirbasCtosBLL()
        {
            _TblDemirbasCtosDAO = new TblDemirbasCtosDAO();
        }

        public TblDemirbasCtosPoco kaydetDemirbasCtos(int id, string departman, string model, string marka, 
            string islemci, string bellek, string disc, string sistemreferansno, string ekranreferans)
        {
            TblDemirbasCtosPoco demirbasCtos = new TblDemirbasCtosPoco();
            DataTable dataTable = new DataTable();

            _TblDemirbasCtosDAO.insertDemirbasCtos(id, departman, model, marka, islemci,
                bellek, disc, sistemreferansno, ekranreferans);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["id"] = Convert.ToInt32(demirbasCtos.id);
                dr["departman"] = demirbasCtos.departman;
                dr["model"] = demirbasCtos.model;
                dr["marka"] = demirbasCtos.marka;
                dr["islemci"] = demirbasCtos.islemci;
                dr["bellek"] = demirbasCtos.bellek;
                dr["disc"] = demirbasCtos.disc;
                dr["sistemreferansno"] = demirbasCtos.sistemreferans;
                dr["ekranreferans"] = demirbasCtos.ekranreferans;
            }

            return demirbasCtos;
        }

        public TblDemirbasCtosPoco guncelleDemirbasCtos(int id, string departman, string model, string marka,
            string islemci, string bellek, string disc, string sistemreferansno, string ekranreferans)
        {
            TblDemirbasCtosPoco demirbasCtos = new TblDemirbasCtosPoco();
            DataTable dataTable = new DataTable();

            _TblDemirbasCtosDAO.updateDemirbasCtos(id, departman, model, marka, islemci, bellek, disc, sistemreferansno, ekranreferans);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["departman"] = demirbasCtos.departman;
                dr["model"] = demirbasCtos.model;
                dr["marka"] = demirbasCtos.marka;
                dr["islemci"] = demirbasCtos.islemci;
                dr["bellek"] = demirbasCtos.bellek;
                dr["disc"] = demirbasCtos.disc;
                dr["sistemreferansno"] = demirbasCtos.sistemreferans;
                dr["ekranreferans"] = demirbasCtos.ekranreferans;
            }

            return demirbasCtos;
        }

        public TblDemirbasCtosPoco silDemirbasCtos(int id) 
        {
            TblDemirbasCtosPoco demirbasCtos = new TblDemirbasCtosPoco();
            DataTable dataTable = new DataTable();

            _TblDemirbasCtosDAO.deleteDemirbasCtos(Convert.ToInt32(id));

            return demirbasCtos;
        }
  

    }
}
