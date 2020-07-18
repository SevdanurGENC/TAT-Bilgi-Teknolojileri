using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TATBilgiTeknolojileri.PocosLayer
{
    public class TblKullaniciGirisiPoco
    {
        private int _id { get; set; }
        private string _kullaniciAdi { get; set; }
        private string _sifre { get; set; }
        private string _isim { get; set; }
        private string _soyIsim { get; set; }

        public TblKullaniciGirisiPoco()
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

        public string kullaniciadi
        {
            get
            {
                return _kullaniciAdi;
            }

            set
            {
                _kullaniciAdi = value;
            }
        }

        public string sifre
        {
            get
            {
                return _sifre;
            }

            set
            {
                _sifre = value;
            }
        }

        public string isim
        {
            get
            {
                return _isim;
            }

            set
            {
                _isim = value;
            }
        }

        public string soyisim
        {
            get
            {
                return _soyIsim;
            }

            set
            {
                _soyIsim = value;
            }
        }

    }
}
