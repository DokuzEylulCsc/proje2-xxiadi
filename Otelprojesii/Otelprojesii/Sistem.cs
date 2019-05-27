using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otelprojesii
{
    class Sistem
    {
        public static Dictionary<int, Kullanici> kullaniciList = new Dictionary<int, Kullanici>();
        public static Dictionary<int, Sehir> sehirList = new Dictionary<int, Sehir>();
        //public static Dictionary<int, Otel> otellerList = new Dictionary<int, Otel>();       
        private static Sistem instance;


        public static Sistem GetInstance()//Singleton desing pattern kullandım
        {
            if (instance == null)
            {
                instance = new Sistem();
            }
            return instance;
        }
        public void SehirEkle(Sehir sehir)
        {
            sehirList.Add(sehir.SehirID, sehir);
        }

        public void KullaniciEkleme(Kullanici kul)
        {
            //KullaniciList.Add(kul);
        }

    }
}
