using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TATBilgiTeknolojileri.PocosLayer
{
    public class TblDemirbasKablosuzWifiEkipmanlariPoco
    {
        private int _id { get; set; }
        private string _cihazadi { get; set; }
        private string _aciklama { get; set; }

        public TblDemirbasKablosuzWifiEkipmanlariPoco()
        { }

        public int id
        {
            get
            { return _id; }
            set
            { _id = value; }
        }

        public string cihazadi
        {
            get
            { return _cihazadi; }
            set
            { _cihazadi = value; }
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
