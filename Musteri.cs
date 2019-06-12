using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class Musteri:Kullanici
    {
        public Musteri(int id, string Ad, string sifre, long telefon, string email) : base(id, Ad, sifre, telefon, email)//kullanicidan aldi
        {

        }
    }
}
