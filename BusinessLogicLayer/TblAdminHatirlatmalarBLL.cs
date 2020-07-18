using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TATBilgiTeknolojileri.DataAccessObjects;
using TATBilgiTeknolojileri.PocosLayer;
using System.Data;

namespace TATBilgiTeknolojileri.BusinessLogicLayer
{
    public class TblAdminHatirlatmalarBLL
    {
        private TblAdminHatirlatmalarDAO _TblAdminHatirlatmalarDAO;

        public TblAdminHatirlatmalarBLL()
        {
            _TblAdminHatirlatmalarDAO = new TblAdminHatirlatmalarDAO();
        }

        public TblAdminHatirlatmalarPoco kaydetAdminHatirlatmalar(int id, string yapilacakistanimlari,
            string tarih)
        {
            TblAdminHatirlatmalarPoco adminHatirlatma = new TblAdminHatirlatmalarPoco();
            DataTable dataTable = new DataTable();

            _TblAdminHatirlatmalarDAO.insertAdminHatirlatmalar(id, yapilacakistanimlari, tarih);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["id"] = Convert.ToInt32(adminHatirlatma.id);
                dr["yapilacakistanimlari"] = adminHatirlatma.yapilacakistanimlari;
                dr["tarih"] = adminHatirlatma.tarih;
            }

            return adminHatirlatma;
        }

        public TblAdminHatirlatmalarPoco guncelleAdminHatirlatmalar(int id, string yapilacakistanimlari,
            string tarih, string onay)
        {
            TblAdminHatirlatmalarPoco adminHatirlatma = new TblAdminHatirlatmalarPoco();
            DataTable dataTable = new DataTable();

            _TblAdminHatirlatmalarDAO.updateAdminHatirlatmalar(id, yapilacakistanimlari, tarih, onay);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["yapilacakistanimlari"] = adminHatirlatma.yapilacakistanimlari;
                dr["tarih"] = adminHatirlatma.tarih;
                dr["onay"] = adminHatirlatma.onay;
            }

            return adminHatirlatma;
        }

        public TblAdminHatirlatmalarPoco silAdminHatirlatmalar(int id) 
        {
            TblAdminHatirlatmalarPoco adminHatirlatma = new TblAdminHatirlatmalarPoco();
            DataTable dataTable = new DataTable();

            _TblAdminHatirlatmalarDAO.deleteAdminHatirlatmalar(Convert.ToInt32(id));

            return adminHatirlatma;
        }
  
    }
}
