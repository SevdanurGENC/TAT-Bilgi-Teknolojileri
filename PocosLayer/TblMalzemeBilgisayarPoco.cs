using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TATBilgiTeknolojileri.PocosLayer
{
    public class TblMalzemeBilgisayarPoco
    {
        private int _id { get; set; }
        private string _departman { get; set; }
        private string _kullaniciIsmi { get; set; }
        private string _kullaniciTamIsmi { get; set; }
        private string _markaModel { get; set; }
        private string _cpu { get; set; }
        private string _memory { get; set; }
        private string _disc { get; set; }
        private string _aygitCdRw { get; set; }
        private string _sistemReferansNo { get; set; }
        private string _sistemYazilimi { get; set; }
        private string _msOffice { get; set; }
        private string _aciklama { get; set; }

        public TblMalzemeBilgisayarPoco()
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

        public string departman
        {
            get
            {
                return _departman;
            }

            set
            {
                _departman = value;
            }
        }

        public string kullaniciIsmi
        {
            get
            {
                return _kullaniciIsmi;
            }

            set
            {
                _kullaniciIsmi = value;
            }
        }

        public string kullaniciTamIsmi
        {
            get
            {
                return _kullaniciTamIsmi;
            }

            set
            {
                _kullaniciTamIsmi = value;
            }
        }

        public string markaModel
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

        public string cpu
        {
            get
            {
                return _cpu;
            }

            set
            {
                _cpu = value;
            }
        }

        public string memory
        {
            get
            {
                return _memory;
            }

            set
            {
                _memory = value;
            }
        }

        public string disc
        {
            get
            {
                return _disc;
            }

            set
            {
                _disc = value;
            }
        }

        public string aygitCdRw
        {
            get
            {
                return _aygitCdRw;
            }

            set
            {
                _aygitCdRw = value;
            }
        }

        public string sistemReferansNo
        {
            get
            {
                return _sistemReferansNo;
            }

            set
            {
                _sistemReferansNo = value;
            }
        }

        public string sistemYazilimi
        {
            get
            {
                return _sistemYazilimi;
            }

            set
            {
                _sistemYazilimi = value;
            }
        }

        public string msOffice
        {
            get
            {
                return _msOffice;
            }

            set
            {
                _msOffice = value;
            }
        }

        public string aciklama
        {
            get { return _aciklama;  }
            set { _aciklama = value; }
        }


    }
}
