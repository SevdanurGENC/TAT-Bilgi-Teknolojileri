using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TATBilgiTeknolojileri.PocosLayer
{
    public class TblServisTakipPoco
    {
        private int _id { get; set; }
        private string _markaModel { get; set; }
        private string _referansNo { get; set; }
        private string _ilgiliDepartmanKisi { get; set; }
        private string _aciklama { get; set; }
        private string _onarim { get; set; }
        private string _ilgiliFirma { get; set; }
        private string _gonderilisTarihi { get; set; }
        private string _alinisTarihi { get; set; }
        private string _sonuc { get; set; }

        public TblServisTakipPoco()
        { 
        
        }

        public int id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string markamodel
        {
            get
            {
                return _markaModel;
            }

            set
            {
                _markaModel = value;
            }
        }

        public string referansno
        {
            get
            {
                return _referansNo;
            }

            set
            {
                _referansNo = value;
            }
        }

        public string ilgilidepartmankisi
        {
            get
            {
                return _ilgiliDepartmanKisi;
            }

            set
            {
                _ilgiliDepartmanKisi = value;
            }
        }

        public string aciklama
        {
            get
            {
                return _aciklama;
            }

            set
            {
                _aciklama = value;
            }
        }

        public string onarim
        {
            get
            {
                return _onarim;
            }

            set
            {
                _onarim = value;
            }
        }

        public string ilgilifirma
        {
            get
            {
                return _ilgiliFirma;
            }

            set
            {
                _ilgiliFirma = value;
            }
        }

        public string gonderilistarihi
        {
            get
            {
                return _gonderilisTarihi;
            }

            set
            {
                _gonderilisTarihi = value;
            }
        }
        
        public string alinistarihi
        {
            get
            {
                return _alinisTarihi;
            }

            set
            {
                _alinisTarihi = value;
            }
        }

        public string sonuc
        {
            get
            {
                return _sonuc;
            }

            set
            {
                _sonuc = value;
            }
        }


    }
}
