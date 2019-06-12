using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    abstract class Oda
    {
        public List<Rezervasyon> Rezervasyonlar { get; set; }//rezervasyonların tutulduğu liste
        private int odaNo;//özellikler
        private bool denizManzarasi;
        private bool tv;
        private bool klima;
        private bool minibar;
        private bool havuzManzarasi;
        private bool internet;
        private double fiyat=0;
        public bool tekkisilikoda = false;
        public bool ciftkisilikoda = false;
        public bool ikizyataklioda = false;
        public double Fiyat//kapsülleme
        {
            get { return fiyat; }
            set { fiyat = value; }
        }
        public int OdaNo
        {
            get { return odaNo; }
            set { odaNo=value; }
        }
        public bool DenizManzarasi
        {
            get { return denizManzarasi; }
            set { denizManzarasi=value; }
        }
        public bool Tv
        {
            get { return tv;}
            set { tv=value; }

        }
        public bool Klima
        {
            get { return klima; }
            set { klima=value; }
        }
        public bool Minibar
        {
            get { return minibar; }
            set { minibar=value; }
        }
        public bool HavuzManzarasi
        {
            get { return havuzManzarasi; }
            set { havuzManzarasi=value; }
        }
        public bool Internet
        {
            get { return internet; }
            set { internet=value; }
        }
        public Oda(int odano, bool denizmanzarasi, bool tv, bool klima, bool minibar, bool havuzmanzarasi, bool internet)//construcutr
        {
            OdaNo = odano;
            DenizManzarasi = denizmanzarasi;
            Tv = tv;
            Klima = klima;
            Minibar = minibar;
            HavuzManzarasi = havuzmanzarasi;
            Internet = internet;
            Fiyatolusturma();
        }

        private void Fiyatolusturma()// fiyat oluşturma kısmı
        {
            if(denizManzarasi==true)
            {
                fiyat += 50;//deniz manzarası +50
            }
            if(tv==true)
            { fiyat += 10; }//tv +10
            if(klima==true)
            { fiyat += 50; }//klima +50
            if(minibar==true)
            { fiyat += 20; }//minibar +20
            if(havuzManzarasi==true)
            { fiyat += 50; }//havuz manzarasi +50
            if (internet==true)
            { fiyat += 10; }//internet +10

        }


        public bool RezervasyonDurumu(DateTime girisTarihi)
        {
            return Rezervasyonlar.Any(x => x.GirisTarihi.Date == girisTarihi.Date);//rezervasyon durumuna bakma
        }

        public void RezervasyonYap(Rezervasyon _rez)
        {
            Rezervasyonlar.Add(_rez);//rezervasyon yapma metodu
        }

        public void RezervasyonIptal(Rezervasyon _rez)
        {
            Rezervasyonlar.Remove(_rez);//rezervasyon iptal etme
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
