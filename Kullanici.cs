using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
   abstract  class Kullanici//musteri ve yönetici kullanıcak
    {
        private int kullaniciId;
        private string kullaniciAdi;
        private string sifre;
        private long telefon;
        private string email;//özellikleri

        public int KullaniciId//id
        {
            get { return kullaniciId; }
            set { kullaniciId = value; }
        }
        public string KullaniciAdi//ad
        {
            get { return kullaniciAdi; }
            set { kullaniciAdi = value; }
        }
        public string Sifre//sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }
        public long Telefon//telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }
       public string Email//mail
       {
            get { return email; }
            set { email = value; }

       }
        
        public Kullanici(int id,string Ad,string sifre,long telefon,string email)//constructur
        {
            KullaniciId = id;
            KullaniciAdi = Ad;
            Sifre = sifre;
            Telefon = telefon;
            Email = email;
        }




    }
}
