using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TATBilgiTeknolojileri.PocosLayer
{
    public class TblDemirbasBilgisayarPoco
    { 
        private int _id { get; set; }
        private string _departman { get; set; }
        private string _makinaismi { get; set; }
        private string _kullaniciismi { get; set; }
        private string _kullanicitamismi { get; set; }
        private string _ekran { get; set; }
        private string _mailadresi { get; set; }
        private string _aciklama { get; set; }
        private string _ip { get; set; }
        private string _markamodel { get; set; }
        private string _model { get; set; }
        private string _cpu { get; set; }
        private string _memory { get; set; }
        private string _disc { get; set; }
        private string _aygitcdrw { get; set; }
        private string _sistemreferansno { get; set; }
        private string _ekranreferansno { get; set; }
        private string _sistemyazilimi { get; set; }
        private string _msoffice { get; set; }
        private string _notbilgisi { get; set; }
        private string _yenipcverilistarihi { get; set; }

        public TblDemirbasBilgisayarPoco()
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
            {   return _departman;    }
            set
            {   _departman = value;   }
        }

        public string makinaismi
        {
            get
            { return _makinaismi; }
            set
            { _makinaismi = value; }
        }

        public string kullaniciismi
        {
            get
            { return _kullaniciismi; }
            set
            { _kullaniciismi = value; }
        }

        public string kullanicitamismi
        {
            get
            { return _kullanicitamismi; }
            set
            { _kullanicitamismi = value; }
        }

        public string ekran
        {
            get
            { return _ekran; }
            set
            { _ekran = value; }
        }

        public string mailadresi
        {
            get
            { return _mailadresi; }
            set
            { _mailadresi = value; }
        }

        public string aciklama
        {
            get
            { return _aciklama; }
            set
            { _aciklama = value; }
        }

        public string ip
        {
            get
            { return _ip; }
            set
            { _ip = value; }
        } 

        public string markamodel
        {
            get
            { return _markamodel; }
            set
            { _markamodel = value; }
        }

        public string model
        {
            get
            { return _model; }
            set
            { _model = value; }
        }

        public string cpu
        {
            get
            { return _cpu; }
            set
            { _cpu = value; }
        }

        public string memory
        {
            get
            { return _memory; }
            set
            { _memory = value; }
        }

        public string disc
        {
            get
            { return _disc; }
            set
            { _disc = value; }
        }

        public string aygitcdrw
        {
            get
            { return _aygitcdrw; }
            set
            { _aygitcdrw = value; }
        }

        public string sistemreferansno
        {
            get
            { return _sistemreferansno; }
            set
            { _sistemreferansno = value; }
        }

        public string ekranreferansno
        {
            get
            { return _ekranreferansno; }
            set
            { _ekranreferansno = value; }
        }

        public string sistemyazilimi
        {
            get
            { return _sistemyazilimi; }
            set
            { _sistemyazilimi = value; }
        }

        public string msoffice
        {
            get
            { return _msoffice; }
            set
            { _msoffice = value; }
        }

        public string notbilgisi
        {
            get
            { return _notbilgisi; }
            set
            { _notbilgisi = value; }
        }

        public string yenipcverilistarihi
        {
            get
            { return _yenipcverilistarihi; }
            set
            { _yenipcverilistarihi = value; }
        }
          

    }
}
