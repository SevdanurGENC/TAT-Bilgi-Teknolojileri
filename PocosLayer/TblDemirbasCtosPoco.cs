using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TATBilgiTeknolojileri.PocosLayer
{
    public class TblDemirbasCtosPoco
    {
        private int _id { get; set; }
        private string _departman { get; set; }
        private string _model { get; set; }
        private string _marka { get; set; }
        private string _islemci { get; set; }
        private string _bellek { get; set; }
        private string _disc { get; set; }
        private string _sistemreferans { get; set; }
        private string _ekranreferans { get; set; }
         
        public TblDemirbasCtosPoco()
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

        public string model
        {
            get
            { return _model; }
            set
            { _model = value; }
        }

        public string marka
        {
            get
            { return _marka; }
            set
            { _marka = value; }
        }

        public string islemci
        {
            get
            { return _islemci; }
            set
            { _islemci = value; }
        }

        public string bellek
        {
            get
            { return _bellek; }
            set
            { _bellek = value; }
        }

        public string disc
        {
            get
            { return _disc; }
            set
            { _disc = value; }
        }

        public string sistemreferans
        {
            get
            { return _sistemreferans; }
            set
            { _sistemreferans = value; }
        }

        public string ekranreferans
        {
            get
            { return _ekranreferans; }
            set
            { _ekranreferans = value; }
        }

    }
}
