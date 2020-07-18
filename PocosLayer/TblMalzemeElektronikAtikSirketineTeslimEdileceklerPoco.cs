using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TATBilgiTeknolojileri.PocosLayer
{
    public class TblMalzemeElektronikAtikSirketineTeslimEdileceklerPoco
    {
        private int _id { get; set; }
        private string _kullaniciadi { get; set; }
        private string _markamodel { get; set; }
        private string _referansno { get; set; }
        private string _sistemserino { get; set; }
        private string _aciklama { get; set; }
        private string _durumu { get; set; }

        public TblMalzemeElektronikAtikSirketineTeslimEdileceklerPoco()
        { }

        public int id
        {
            get
            { return _id; }
            set
            { _id = value; }
        }

        public string kullaniciadi
        {
            get
            { return _kullaniciadi; }
            set
            { _kullaniciadi = value; }
        }

        public string markamodel
        {
            get
            { return _markamodel; }
            set
            { _markamodel = value; }
        }

        public string referansno
        {
            get
            { return _referansno; }
            set
            { _referansno = value; }
        }

        public string sistemserino
        {
            get
            { return _sistemserino; }
            set
            { _sistemserino = value; }
        }

        public string aciklama
        {
            get
            { return _aciklama; }
            set
            { _aciklama = value; }
        }

        public string durumu
        {
            get
            { return _durumu; }
            set
            { _durumu = value; }
        }

         
    }
}
