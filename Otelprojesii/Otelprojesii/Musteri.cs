﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otelprojesii
{
    class Musteri:Kullanici
    {
        public Musteri(int Id, string Ad, string sifre, int telefon, string email) : base(Id, Ad, sifre, telefon, email)
        {

        }
    }
}
