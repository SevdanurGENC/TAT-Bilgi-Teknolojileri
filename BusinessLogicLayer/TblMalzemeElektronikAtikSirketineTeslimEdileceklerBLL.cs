using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TATBilgiTeknolojileri.DataAccessObjects;
using TATBilgiTeknolojileri.PocosLayer;
using System.Data;

namespace TATBilgiTeknolojileri.BusinessLogicLayer
{
    public class TblMalzemeElektronikAtikSirketineTeslimEdileceklerBLL
    {
        private TblMalzemeElektronikAtikSirketineTeslimEdileceklerDAO _TblMalzemeElektronikAtikSirketineTeslimEdileceklerDAO;

        public TblMalzemeElektronikAtikSirketineTeslimEdileceklerBLL()
        {
            _TblMalzemeElektronikAtikSirketineTeslimEdileceklerDAO = new TblMalzemeElektronikAtikSirketineTeslimEdileceklerDAO();
        }


        public TblMalzemeElektronikAtikSirketineTeslimEdileceklerPoco kaydetMalzemeElektronik(int id, string kullaniciadi, 
            string markamodel, string referansno, string sistemserino, string aciklama, string durumu )
        {
            TblMalzemeElektronikAtikSirketineTeslimEdileceklerPoco MalzemeElektronik = new TblMalzemeElektronikAtikSirketineTeslimEdileceklerPoco();
            DataTable dataTable = new DataTable();

            _TblMalzemeElektronikAtikSirketineTeslimEdileceklerDAO.insertMalzemeElektronik(id, kullaniciadi, markamodel, referansno,
                sistemserino, aciklama, durumu);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["id"] = Convert.ToInt32(MalzemeElektronik.id);
                dr["departman"] = MalzemeElektronik.kullaniciadi;
                dr["model"] = MalzemeElektronik.markamodel;
                dr["marka"] = MalzemeElektronik.referansno;
                dr["islemci"] = MalzemeElektronik.sistemserino;
                dr["bellek"] = MalzemeElektronik.aciklama;
                dr["disc"] = MalzemeElektronik.durumu;
            }

            return MalzemeElektronik;
        }

        public TblMalzemeElektronikAtikSirketineTeslimEdileceklerPoco guncelleMalzemeElektronik(int id, string kullaniciadi,
            string markamodel, string referansno, string sistemserino, string aciklama, string durumu)
        {
            TblMalzemeElektronikAtikSirketineTeslimEdileceklerPoco MalzemeElektronik = new TblMalzemeElektronikAtikSirketineTeslimEdileceklerPoco();
            DataTable dataTable = new DataTable();

            _TblMalzemeElektronikAtikSirketineTeslimEdileceklerDAO.updateMalzemeElektronik(id, kullaniciadi, markamodel, referansno,
                sistemserino, aciklama, durumu);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["departman"] = MalzemeElektronik.kullaniciadi;
                dr["model"] = MalzemeElektronik.markamodel;
                dr["marka"] = MalzemeElektronik.referansno;
                dr["islemci"] = MalzemeElektronik.sistemserino;
                dr["bellek"] = MalzemeElektronik.aciklama;
                dr["disc"] = MalzemeElektronik.durumu;
            }

            return MalzemeElektronik;
        }

        public TblMalzemeElektronikAtikSirketineTeslimEdileceklerPoco silMalzemeElektronik(int id)
        {
            TblMalzemeElektronikAtikSirketineTeslimEdileceklerPoco MalzemeElektronik = new TblMalzemeElektronikAtikSirketineTeslimEdileceklerPoco();
            DataTable dataTable = new DataTable();

            _TblMalzemeElektronikAtikSirketineTeslimEdileceklerDAO.deleteMalzemeElektronik(Convert.ToInt32(id));

            return MalzemeElektronik;
        }
  








    }
}
