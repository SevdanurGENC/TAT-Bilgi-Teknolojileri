using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TATBilgiTeknolojileri.PocosLayer
{
    public class TblDemirbasSwitchPoco
    {
        private int _id { get; set; }
        private string _bulunduguyer { get; set; }
        private string _marka { get; set; }
        private string _ekbilgi { get; set; }
        private string _aciklama { get; set; }

        public TblDemirbasSwitchPoco()
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
 
        public string marka
        {
            get
            { return _marka; }
            set
            { _marka = value; }
        }

        public string bulunduguyer
        {
            get
            { return _bulunduguyer; }
            set
            { _bulunduguyer = value; }
        }

        public string ekbilgi
        {
            get
            { return _ekbilgi; }
            set
            { _ekbilgi = value; }
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
