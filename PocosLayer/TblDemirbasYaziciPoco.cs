using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TATBilgiTeknolojileri.PocosLayer
{
    public class TblDemirbasYaziciPoco
    {
        private int _id { get; set; }
        private string _model { get; set; }
        private string _tip { get; set; }
        private string _siyah { get; set; }  
        private string _renkli { get; set; }
        private string _mavi { get; set; }
        private string _sari { get; set; }
        private string _kirmizi { get; set; }
        private string _departman { get; set; }
        private string _kullanici { get; set; }
        private string _ip { get; set; }
        private string _serino { get; set; }
        private string _aciklama { get; set; }

        public TblDemirbasYaziciPoco()
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

        public string model
        {
            get
            { return _model; }
            set
            { _model = value; }
        }

        public string tip
        {
            get
            { return _tip; }
            set
            { _tip = value; }
        }

        public string siyah
        {
            get
            { return _siyah; }
            set
            { _siyah = value; }
        }
 
        public string renkli
        {
            get
            { return _renkli; }
            set
            { _renkli = value; }
        }

        public string mavi
        {
            get
            { return _mavi; }
            set
            { _mavi = value; }
        }

        public string sari
        {
            get
            { return _sari; }
            set
            { _sari = value; }
        }

        public string kirmizi
        {
            get
            { return _kirmizi; }
            set
            { _kirmizi = value; }
        }

        public string departman
        {
            get
            { return _departman; }
            set
            { _departman = value; }
        }

        public string kullanici
        {
            get
            { return _kullanici; }
            set
            { _kullanici = value; }
        }

        public string ip
        {
            get
            { return _ip; }
            set
            { _ip = value; }
        }

        public string serino
        {
            get
            { return _serino; }
            set
            { _serino = value; }
        }

        public string aciklama
        {
            get
            { return _aciklama; }
            set
            { _aciklama = value; }
        } 

         
    }
}
