using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TATBilgiTeknolojileri.PocosLayer
{
    public class TblSatinAlmalarPoco
    {
        private int _id  { get; set; }
        private string _isim  { get; set; }
        private string _soyIsim  { get; set; }
        private string _isletme  { get; set; }
        private string _departman { get; set; }
        private string _istek { get; set; }
        private string _istekTarihi { get; set; }
        private string _kullaniciyaTeslimTarihi { get; set; }
        private string _rapor { get; set; }

        public TblSatinAlmalarPoco()
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
        
        public string isletme
        {
            get
            {
                return _isletme;
            }

            set
            {
                _isletme = value;
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

        public string istek
        {
            get
            {
                return _istek;
            }

            set
            {
                _istek = value;
            }
        }

        public string istektarihi
        {
            get
            {
                return _istekTarihi;
            }

            set
            {
                _istekTarihi = value;
            }
        }

        public string kullaniciyateslimtarihi
        {
            get
            {
                return _kullaniciyaTeslimTarihi;
            }

            set
            {
                _kullaniciyaTeslimTarihi = value;
            }
        }

        public string rapor
        {
            get
            {
                return _rapor;
            }

            set
            {
                _rapor = value;
            }
        } 
         
    }
}
