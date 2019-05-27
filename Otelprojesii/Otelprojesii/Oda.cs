using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otelprojesii
{
    class Oda
    {
        private int odaNo;
        private bool denizManzarasi;
        private bool tv;
        private bool klima;
        private bool minibar;
        private bool havuzManzarasi;
        private bool internet;
        private bool tekkisilikoda = false;
        private bool ciftkisilikoda = false;
        private bool ikizyataklioda = false;
        private string fiyat;
        public List<Rezervasyon> Rezervasyonlar { get; set; }

        public int OdaNo
        {
            get { return odaNo; }
            set { value = odaNo; }
        }
        public bool DenizManzarasi
        {
            get { return denizManzarasi; }
            set { value = denizManzarasi; }
        }
        public bool Tv
        {
            get { return tv; }
            set { value = tv; }

        }
        public bool Klima
        {
            get { return klima; }
            set { value = klima; }
        }
        public bool Minibar
        {
            get { return minibar; }
            set { value = minibar; }
        }
        public bool HavuzManzarasi
        {
            get { return havuzManzarasi; }
            set { value = havuzManzarasi; }
        }
        public bool Internet
        {
            get { return internet; }
            set { value = internet; }
        }

        public bool TekkisilikOda
        {
            get { return tekkisilikoda; }
            set { value = tekkisilikoda; }
        }

        public bool CiftKisilikOda
        {
            get { return ciftkisilikoda; }
            set { value = ciftkisilikoda; }
        }

        public bool IkizYatakliOda
        {
            get { return ikizyataklioda; }
            set { value = ikizyataklioda; }
        }

        public string Fiyat
        {
            get { return fiyat; }
            set { value = fiyat; }
        }

        public Oda()
        {
            Rezervasyonlar = new List<Rezervasyon>();
        }

        public bool RezervasyonDurumu(DateTime girisTarihi)
        {
            return Rezervasyonlar.Any(x => x.GirisTarihi.Date == girisTarihi.Date);
        }

        public void RezervasyonYap(Rezervasyon _rez)
        {
            Rezervasyonlar.Add(_rez);
        }

        public void RezervasyonIptal(Rezervasyon _rez)
        {
            Rezervasyonlar.Remove(_rez);
        }


        public override string ToString()
        {
            string ozellik = "";
            if (DenizManzarasi && HavuzManzarasi)
            {
                ozellik = " (Deniz ve Havuz Manzaralı)";
            }
            else if (DenizManzarasi)
            {
                ozellik = " (Deniz Manzaralı)";
            }
            else if (HavuzManzarasi)
            {
                ozellik = " (Havuz Manzaralı)";
            }

            return OdaNo.ToString() + ozellik;
        }
    }
}
