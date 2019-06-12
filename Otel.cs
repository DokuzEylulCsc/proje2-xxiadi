using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    abstract class Otel
    {
        public Dictionary<int ,Oda> OdalarList = new Dictionary<int, Oda>();//otellerin içinde bulunan odalar list
        private int yildiz;
        private int otelId;
        private string otelAd;
        private bool spa;
        private bool havuz;
        private bool sporSalonu;
        public bool pansiyon = false;
        public bool butikotel = false;
        public bool tatilkoyu = false;

        public  void OdaEkle(Oda oda)//odalar listesine oda ekleme 
        {
            OdalarList.Add(oda.OdaNo,oda);
        }
       
        public int Yildiz//kapsülleme
        {
            get { return yildiz; }
            set { yildiz=value; }
        }
        public int OtelId
        {
            get { return otelId; }
            set { otelId=value; }
        }
        public string OtelAd
        {
            get { return otelAd; }
            set { otelAd=value; }
        }
        public bool Spa
        {
            get { return spa; }
            set { spa = value; }
        }
        public bool Havuz
        {
            get { return havuz; }
            set { havuz=value; }
        }
        public bool SporSalonu
        {
            get { return sporSalonu; }
            set { sporSalonu=value; }
        }
        public Otel(int otelid, string otelad, int yildiz, bool spa, bool havuz, bool sporsalonu)//constructor
        {
            OtelId = otelid;
            OtelAd = otelad;
            Yildiz = yildiz;
            Spa = spa;
            Havuz = havuz;
            SporSalonu = sporsalonu;
        }
       
        public bool RezervasyonDurumu(Oda _oda,DateTime girisTarihi)//rezervasyon durumu
        {
            
                var state = _oda.Rezervasyonlar.Any(x => x.GirisTarihi.Date == girisTarihi.Date);

                if (!state)
                {
                    state = _oda.Rezervasyonlar.Any(x => x.GirisTarihi < girisTarihi.Date && x.CikisTarihi.Date > girisTarihi);//giriş tarihi çıkış tarihi  arasında ki hata kontrolu
                }

                return state;
            
        }

        public void RezervasyonYap(Oda _oda, Rezervasyon _rez)//rezervasyon yapma metodu
        {
            _oda.Rezervasyonlar.Add(_rez);
        }
        /////////////////////////////////////////////////////////buraların commetini kaldırında hata veriyor ama rezervasyon iptak ve doluluk oranları metodları burada
        //public bool RezervasyonIptal(Rezervasyon _rez)
        //{
        //    var _oda = OdalarList.FirstOrDefault(x => x.Numara == _rez.OdaNumarasi);
        //    if (_oda != null)
        //    {
        //        _oda.Rezervasyonlar.Remove(_rez);
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public float DolulukOrani(DateTime girisTarihi)
        //{
        //    int count = 0;
        //    foreach (var oda in OdalarList)
        //    {
        //        if (oda.Rezervasyonlar.Any(y => y.GirisTarihi.Date == girisTarihi.Date))
        //        {
        //            count++;
        //        }
        //    }

        //    return (count / (float)OdalarList.Count) * 100;
        //}
    }
}
