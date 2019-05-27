using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otelprojesii
{
    class Rezervasyon
    {
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public int OdaNumarasi { get; set; }
        public bool IptalEdildi { get; set; }
        public List<Kullanici> kullanici { get; set; }

        public string musteri
        {
            get
            {
                string kul = "";
                foreach (var item in kullanici)
                {
                    kul += item.KullaniciAdi + ",";
                }
                return kul;
            }
        }

        public override string ToString()
        {
            return OdaNumarasi + ", G: " + GirisTarihi.Date.ToString("dd.MM.yyyy") + " Ç: " + CikisTarihi.Date.ToString("dd.MM.yyyy");
        }
    }
}

