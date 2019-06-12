using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class Sehir
    {
        public Dictionary<int, Otel> OtellerList = new Dictionary<int, Otel>();//otellerin bulunduğu liste
        private string sehirAd;
        private int sehirId; 
        

        public void OtelEkle(Otel otel)//sehirlerimin içine otel ekleme
        {
            OtellerList.Add(otel.OtelId, otel);//oteller listesine
        }
        public Sehir(int id,string ad)
        {
            SehirID = id;
            SehirAd = ad;
        }
        public string SehirAd//sehir ismi
        {
            get { return sehirAd; }
            set { sehirAd = value; }
        }
        public int SehirID////id
        {
            get { return sehirId; }
            set { sehirId = value; }
        }
    }
}
