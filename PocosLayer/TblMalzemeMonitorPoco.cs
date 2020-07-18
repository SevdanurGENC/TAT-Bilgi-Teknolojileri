using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TATBilgiTeknolojileri.PocosLayer
{
    public class TblMalzemeMonitorPoco
    {
        public TblMalzemeMonitorPoco()
        { }

        private int _id { get; set; }
        private string _kullaniciAdi { get; set; }
        private string _markaModel { get; set; }
        private string _referansNo { get; set; }
        private string _sistemSeriNo { get; set; }
        private string _aciklama { get; set; }
        private string _monitorDurumu { get; set; }

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string kullaniciAdi
        {
            get { return _kullaniciAdi; }
            set { _kullaniciAdi = value; }
        }

        public string markaModel
        {
            get { return _markaModel; }
            set { _markaModel = value; }
        }

        public string referansNo
        {
            get { return _referansNo; }
            set { _referansNo = value; }
        }

        public string sistemSeriNo
        {
            get { return _sistemSeriNo; }
            set { _sistemSeriNo = value; }
        }

        public string aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        }
        
        public string monitorDurumu
        {
            get { return _monitorDurumu; }
            set { _monitorDurumu = value; }
        }


    }
}
