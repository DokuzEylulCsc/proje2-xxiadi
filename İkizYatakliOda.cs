using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class İkizYatakliOda:Oda
    {
        public İkizYatakliOda(int odano, bool denizmanzarasi, bool tv, bool klima, bool minibar, bool havuzmanzarasi, bool internet) : base
            (odano, denizmanzarasi, tv, klima, minibar, havuzmanzarasi, internet)
        {
            Fiyat += 100;//fiyat ekleme
            ikizyataklioda = true;///ikiz yataklı oda alır
        }

    }
}
