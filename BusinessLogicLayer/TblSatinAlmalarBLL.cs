using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TATBilgiTeknolojileri.DataAccessObjects;
using TATBilgiTeknolojileri.PocosLayer;
using System.Data;

namespace TATBilgiTeknolojileri.BusinessLogicLayer
{
    public class TblSatinAlmalarBLL
    {
        private TblSatinAlmalarDAO _TblSatinAlmalarDAO;

        public TblSatinAlmalarBLL()
        {
            _TblSatinAlmalarDAO = new TblSatinAlmalarDAO();        
        }

        public TblSatinAlmalarPoco kaydetSatinAlma(int id, string isim, string soyisim, string isletme, string departman,
            string istek, string istektarihi, string kullaniciyateslimtarihi, string rapor)
        {
            TblSatinAlmalarPoco satinAlma = new TblSatinAlmalarPoco();
            DataTable dataTable = new DataTable();

            _TblSatinAlmalarDAO.insertSatinAlma(id, isim, soyisim, isletme, departman, istek,
                istektarihi, kullaniciyateslimtarihi, rapor);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["id"] = Convert.ToInt32(satinAlma.id);
                dr["isim"] = satinAlma.isim;
                dr["soyisim"] = satinAlma.soyisim;
                dr["isletme"] = satinAlma.isletme;
                dr["departman"] = satinAlma.departman;
                dr["istek"] = satinAlma.istek;
                dr["istektarihi"] = satinAlma.istektarihi;
                dr["kullaniciyateslimtarihi"] = satinAlma.kullaniciyateslimtarihi;
                dr["rapor"] = satinAlma.rapor; 
            }

            return satinAlma;
        }

        public TblSatinAlmalarPoco guncelleSatinAlma(int id, string isim, string soyisim, string isletme, string departman,
           string istek, string istektarihi, string kullaniciyateslimtarihi, string rapor)
        {
            TblSatinAlmalarPoco satinAlma = new TblSatinAlmalarPoco();
            DataTable dataTable = new DataTable();

            _TblSatinAlmalarDAO.updateSatinAlma(id, isim, soyisim, isletme, departman, istek,
                istektarihi, kullaniciyateslimtarihi, rapor);
           
            foreach (DataRow dr in dataTable.Rows)
            {
                dr["isim"] = satinAlma.isim;
                dr["soyisim"] = satinAlma.soyisim;
                dr["isletme"] = satinAlma.isletme;
                dr["departman"] = satinAlma.departman;
                dr["istek"] = satinAlma.istek;
                dr["istektarihi"] = satinAlma.istektarihi;
                dr["kullaniciyateslimtarihi"] = satinAlma.kullaniciyateslimtarihi;
                dr["rapor"] = satinAlma.rapor;
            } 
            return satinAlma; 
        }

        public TblSatinAlmalarPoco silSatinAlma(int id)
        {
            TblSatinAlmalarPoco satinAlma = new TblSatinAlmalarPoco();
            DataTable dataTable = new DataTable();

            _TblSatinAlmalarDAO.deleteSatinAlma(Convert.ToInt32(id));

            return satinAlma;
        }


    }
}
