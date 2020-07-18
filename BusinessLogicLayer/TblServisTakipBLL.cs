using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TATBilgiTeknolojileri.DataAccessObjects;
using TATBilgiTeknolojileri.PocosLayer;
using System.Data;

namespace TATBilgiTeknolojileri.BusinessLogicLayer
{
    public class TblServisTakipBLL
    {
        private TblServisTakipDAO _TblServisTabipDAO;

        public TblServisTakipBLL()
        {
            _TblServisTabipDAO = new TblServisTakipDAO();
        }

        public TblServisTakipPoco kaydetServisTakip(int id, string markamodel, string referansno, string ilgilidepartmankisi,
            string aciklama, string onarim, string ilgilifirma, string gonderilistarihi, string alinistarihi, string sonuc)
        {
            TblServisTakipPoco servisTakip = new TblServisTakipPoco();
            DataTable dataTable = new DataTable();

            _TblServisTabipDAO.insertServisTakip(id, markamodel, referansno, ilgilidepartmankisi, aciklama, onarim, ilgilifirma, gonderilistarihi, alinistarihi, sonuc);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["id"] = Convert.ToInt32(servisTakip.id);
                dr["markamodel"] = servisTakip.markamodel;
                dr["referansno"] = servisTakip.referansno;
                dr["ilgilidepartmankisi"] = servisTakip.ilgilidepartmankisi;
                dr["aciklama"] = servisTakip.aciklama;
                dr["onarim"] = servisTakip.onarim;
                dr["ilgilifirma"] = servisTakip.ilgilifirma;
                dr["gonderilistarihi"] = servisTakip.gonderilistarihi;
                dr["alinistarihi"] = servisTakip.alinistarihi;
                dr["sonuc"] = servisTakip.sonuc;
            }

            return servisTakip;
        }

        public TblServisTakipPoco guncelleServisTakip(int id, string markamodel, string referansno, string ilgilidepartmankisi,
          string aciklama, string onarim, string ilgilifirma, string gonderilistarihi, string alinistarihi, string sonuc)
        {
            TblServisTakipPoco servisTakip = new TblServisTakipPoco();
            DataTable dataTable = new DataTable();

            _TblServisTabipDAO.updateServisTakip(id, markamodel, referansno, ilgilidepartmankisi, aciklama, onarim, ilgilifirma, gonderilistarihi, alinistarihi, sonuc);

            foreach (DataRow dr in dataTable.Rows)
            { 
                dr["markamodel"] = servisTakip.markamodel;
                dr["referansno"] = servisTakip.referansno;
                dr["ilgilidepartmankisi"] = servisTakip.ilgilidepartmankisi;
                dr["aciklama"] = servisTakip.aciklama;
                dr["onarim"] = servisTakip.onarim;
                dr["ilgilifirma"] = servisTakip.ilgilifirma;
                dr["gonderilistarihi"] = servisTakip.gonderilistarihi;
                dr["alinistarihi"] = servisTakip.alinistarihi;
                dr["sonuc"] = servisTakip.sonuc;
            }

            return servisTakip;
        }

        public TblServisTakipPoco silServisTakip(int id)   //Kullanici listesinde secilen bir kaydin bilgilerini sistemden tamamen siler.
        {
            TblServisTakipPoco servisTakip = new TblServisTakipPoco();
            DataTable dataTable = new DataTable();

            _TblServisTabipDAO.deleteServisTakip(Convert.ToInt32(id));

            return servisTakip;
        }

    }
}
