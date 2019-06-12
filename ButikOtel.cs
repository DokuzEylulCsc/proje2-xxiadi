using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class ButikOtel:Otel
    {
        public ButikOtel(int otelid, string otelad, int yildiz, bool spa, bool havuz, bool sporsalonu) : base(otelid,otelad, yildiz, spa, havuz, sporsalonu)
        {
            butikotel = true;//butik otel alır
        }

       
    }
}
