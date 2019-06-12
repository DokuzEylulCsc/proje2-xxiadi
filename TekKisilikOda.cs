using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class TekKisilikOda :Oda
    {
        public TekKisilikOda(int odano, bool denizmanzarasi, bool tv, bool klima, bool minibar, bool havuzmanzarasi, bool internet):base
            (odano,denizmanzarasi,tv,klima,minibar,havuzmanzarasi,internet)//odadan alır
        {
            Fiyat += 50;//fiyat +50 artar
            tekkisilikoda = true;//tek kisilik oda alır

        }
        
    }
}
