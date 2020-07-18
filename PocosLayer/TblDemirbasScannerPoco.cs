using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TATBilgiTeknolojileri.PocosLayer
{
    public class TblDemirbasScannerPoco
    {
        private int _id { get; set; }
        private string _model { get; set; }
        private string _tip { get; set; }
        private string _referansno { get; set; }
        private string _departman { get; set; }
        private string _kullanici { get; set; }
        private string _yeniscannerverilistarihi { get; set; }

        public TblDemirbasScannerPoco()
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

        public string referansno
        {
            get
            { return _referansno; }
            set
            { _referansno = value; }
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

        public string yeniscannerverilistarihi
        {
            get
            { return _yeniscannerverilistarihi; }
            set
            { _yeniscannerverilistarihi = value; }
        }

        

    }
}
