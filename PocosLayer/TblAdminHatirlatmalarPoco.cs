using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TATBilgiTeknolojileri.PocosLayer
{
    public class TblAdminHatirlatmalarPoco
    {
        private int _id { get; set; }
        private string _yapilacakistanimlari { get; set; }
        private string _tarih { get; set; }
        private string _onay { get; set; }

        public TblAdminHatirlatmalarPoco()
        { }

        public int id
        {
            get
            { return _id; }
            set
            { _id = value; }
        }

        public string yapilacakistanimlari
        {
            get
            { return _yapilacakistanimlari; }
            set
            { _yapilacakistanimlari = value; }
        }

        public string tarih
        {
            get
            { return _tarih; }
            set
            { _tarih = value; }
        }

        public string onay
        {
            get
            { return _onay; }
            set
            { _onay = value; }
        }


    }
}
