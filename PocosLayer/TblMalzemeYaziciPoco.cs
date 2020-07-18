using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TATBilgiTeknolojileri.PocosLayer
{
    public class TblMalzemeYaziciPoco
    {
        public TblMalzemeYaziciPoco()
        { }

        private int _id { get; set; }
        private string _kullaniciDepartman { get; set; }
        private string _model { get; set; }
        private string _tip { get; set; }
        private string _siyah { get; set; }
        private string _renkli { get; set; }
        private string _mavi { get; set; }
        private string _sari { get; set; }
        private string _kirmizi { get; set; }
        private string _referansNo { get; set; }
        private string _seriNo { get; set; }
        private string _aciklama { get; set; }
        private string _yaziciDurumu { get; set; }


        public int id
        {
            get { return _id; }
            set { _id = value; }
        } 

        public string kullaniciDepartman
        {
            get { return _kullaniciDepartman; }
            set { _kullaniciDepartman = value; }
        }

        public string model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string tip
        {
            get { return _tip; }
            set { _tip = value; }
        }

        public string siyah
        {
            get { return _siyah; }
            set { _siyah = value; }
        }

        public string renkli
        {
            get { return _renkli; }
            set { _renkli = value; }
        }

        public string mavi
        {
            get { return _mavi; }
            set { _mavi = value; }
        }

        public string sari
        {
            get { return _sari; }
            set { _sari = value; }
        }

        public string kirmizi
        {
            get { return _kirmizi; }
            set { _kirmizi = value; }
        }

        public string referansNo
        {
            get { return _referansNo; }
            set { _referansNo = value; }
        }

        public string seriNo
        {
            get { return _seriNo; }
            set { _seriNo = value; }
        }

        public string aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        }

        public string yaziciDurumu
        {
            get { return _yaziciDurumu; }
            set { _yaziciDurumu = value; }
        }



    }
}
