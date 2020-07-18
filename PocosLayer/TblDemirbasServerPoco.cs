using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TATBilgiTeknolojileri.PocosLayer
{
    public class TblDemirbasServerPoco
    { 
        private int _id { get; set; }
        private string _departman { get; set; }
        private string _serveradi { get; set; }
        private string _ip { get; set; }
        private string _marka { get; set; }
        private string _model { get; set; }
        private string _cpu { get; set; }
        private string _memory { get; set; }
        private string _disc { get; set; }
        private string _aygitcdrw { get; set; }
        private string _sistemreferansno { get; set; }
        private string _ekranreferans { get; set; }
        private string _sistemyazilimi { get; set; }

        public TblDemirbasServerPoco()
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
            { return _departman; }
            set
            { _departman = value; }
        }

        public string serveradi
        {
            get
            { return _serveradi; }
            set
            { _serveradi = value; }
        }

        public string ip
        {
            get
            { return _ip; }
            set
            { _ip = value; }
        }

        public string marka
        {
            get
            { return _marka; }
            set
            { _marka = value; }
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

        public string ekranreferans
        {
            get
            { return _ekranreferans; }
            set
            { _ekranreferans = value; }
        }

        public string sistemyazilimi
        {
            get
            { return _sistemyazilimi; }
            set
            { _sistemyazilimi = value; }
        }

    }
}
