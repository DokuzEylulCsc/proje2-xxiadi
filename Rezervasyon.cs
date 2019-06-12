using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class Rezervasyon
    {
       

        public DateTime OlusturmaTarihi { get; set; }// datetimeda rezervsyon oluşturma 
        public DateTime GirisTarihi { get; set; }//giriş
        public DateTime CikisTarihi { get; set; }//cıkıs
        public int OdaNumarasi { get; set; }//oda no
        public bool IptalEdildi { get; set; }//iptal
        public List<Musteri> Musteriler { get; set; }//musteri listesi


        public string misafiler
        {
            get
            {
                string _mis = "";
                foreach (var item in Musteriler)
                {
                    _mis += item.KullaniciAdi + ",";//müşterilerin isimlerini yazma
                }
                return _mis;
            }
        }
        
        public override string ToString()
        {
            return OdaNumarasi + ", G: " + GirisTarihi.Date.ToString("dd.MM.yyyy") + " Ç: " + CikisTarihi.Date.ToString("dd.MM.yyyy");//oda numarasi giriş tarihi ve çıkış tarihi yazdırma
        }
       
    }
}
