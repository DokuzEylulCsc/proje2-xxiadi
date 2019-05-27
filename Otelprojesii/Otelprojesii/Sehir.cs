using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otelprojesii
{
    class Sehir
    {
        Dictionary<int, Otel> OtellerList = new Dictionary<int, Otel>();
        private string sehirAd;
        private int sehirId; //??
        //static int sehirId;

        public void OtelEkle(Otel otel)
        {
            OtellerList.Add(otel.OtelId, otel);
        }
        public Sehir(int id, string ad)
        {
            SehirID = id;
            SehirAd = ad;
        }
        public string SehirAd
        {
            get { return sehirAd; }
            set { sehirAd = value; }
        }
        public int SehirID
        {
            get { return sehirId; }
            set { sehirId = value; }
        }
    }
}
