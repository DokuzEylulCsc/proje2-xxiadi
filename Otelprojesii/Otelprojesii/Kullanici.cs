using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otelprojesii
{
    abstract class Kullanici
    {
        private int kullaniciId;
        private string kullaniciAdi;
        private string sifre;
        private int telefon;
        private string email;

        public int KullaniciId
        {
            get { return kullaniciId; }
            set { kullaniciId = value; }
        }
        public string KullaniciAdi
        {
            get { return kullaniciAdi; }
            set { kullaniciAdi = value; }
        }
        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }
        public int Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }

        }

        public Kullanici(int Id, string Ad, string sifre, int telefon, string email)
        {
            KullaniciId = Id;
            KullaniciAdi = Ad;
            Sifre = sifre;
            Telefon = telefon;
            Email = email;
        }




    }
}
