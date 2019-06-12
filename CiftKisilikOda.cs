using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class CiftKisilikOda:Oda
    {
        public CiftKisilikOda(int odano, bool denizmanzarasi, bool tv, bool klima, bool minibar, bool havuzmanzarasi, bool internet) : base
            (odano, denizmanzarasi, tv, klima, minibar, havuzmanzarasi, internet)
        {
            Fiyat += 75;//fiyat ekleme
            ciftkisilikoda = true;//cift kisilik oda alır
        }
       
    }
}
