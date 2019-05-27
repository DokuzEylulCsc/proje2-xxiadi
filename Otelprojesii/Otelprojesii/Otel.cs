using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otelprojesii
{
   abstract class Otel
    {
        List<Oda> OdalarList = new List<Oda>();
        private int yildiz;
        private int otelId;
        private string otelAd;
        private bool spa;
        private bool havuz;
        private bool sporSalonu;

        public abstract void OdaEkle();

        public int Yildiz
        {
            get { return yildiz; }
            set { value = yildiz; }
        }
        public int OtelId
        {
            get { return otelId; }
            set { value = otelId; }
        }
        public string OtelAd
        {
            get { return otelAd; }
            set { value = otelAd; }
        }
        public bool Spa
        {
            get { return spa; }
            set { value = spa; }
        }
        public bool Havuz
        {
            get { return havuz; }
            set { value = havuz; }
        }
        public bool SporSalonu
        {
            get { return sporSalonu; }
            set { value = sporSalonu; }
        }
        public Otel(int otelid, string otelad, int yildiz, bool spa, bool havuz, bool sporsalonu)
        {
            OtelId = otelid;
            OtelAd = otelad;
            Yildiz = yildiz;
            Spa = spa;
            Havuz = havuz;
            SporSalonu = sporsalonu;

        }

        List<Oda> OdaOlustur(OtelTipi otelTipi)
        {
            var odalar = new List<Oda>();
            switch (otelTipi)
            {
                case OtelTipi.Pansiyon:
                    OdalarList.AddRange(new List<Oda>()
                    {
                       new Oda(){ OdaNo=100,TekkisilikOda=true,DenizManzarasi=false,HavuzManzarasi=false,Fiyat="100TL" },
                       new Oda(){ OdaNo=101,TekkisilikOda=true,DenizManzarasi=false,HavuzManzarasi=false,Fiyat="100TL" },
                       new Oda(){ OdaNo=102,TekkisilikOda=true,DenizManzarasi=false,HavuzManzarasi=false,Fiyat="100TL" },
                       new Oda(){ OdaNo=103,TekkisilikOda=true,DenizManzarasi=false,HavuzManzarasi=false,Fiyat="100TL" },
                       new Oda(){ OdaNo=104,TekkisilikOda=true,DenizManzarasi=false,HavuzManzarasi=false,Fiyat="100TL" },
                       new Oda(){ OdaNo=105,CiftKisilikOda=true,DenizManzarasi=false,HavuzManzarasi=false,Fiyat="100TL" },
                       new Oda(){ OdaNo=106,CiftKisilikOda=true,DenizManzarasi=false,HavuzManzarasi=false,Fiyat="100TL" },
                       new Oda(){ OdaNo=107,CiftKisilikOda=true,DenizManzarasi=false,HavuzManzarasi=false,Fiyat="100TL" },
                       new Oda(){ OdaNo=108,CiftKisilikOda=true,DenizManzarasi=false,HavuzManzarasi=false,Fiyat="100TL" },
                       new Oda(){ OdaNo=109,CiftKisilikOda=true,DenizManzarasi=false,HavuzManzarasi=false,Fiyat="100TL" },

                    });
                    break;
                case OtelTipi.TatilKoyu:
                    OdalarList.AddRange(new List<Oda>()
                    {
                        new Oda(){ OdaNo=100,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=false,Fiyat="100TL" },
                        new Oda(){ OdaNo=101,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=false,Fiyat="100TL" },
                        new Oda(){ OdaNo=102,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=false,Fiyat="100TL" },
                        new Oda(){ OdaNo=103,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=false,Fiyat="100TL" },
                        new Oda(){ OdaNo=104,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=false,Fiyat="100TL" },
                        new Oda(){ OdaNo=105,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=false,Fiyat="100TL" },
                        new Oda(){ OdaNo=106,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=false,Fiyat="100TL" },


                        new Oda(){ OdaNo=100,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="100TL" },
                        new Oda(){ OdaNo=101,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="100TL" },
                        new Oda(){ OdaNo=102,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="100TL" },
                        new Oda(){ OdaNo=103,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="100TL" },
                        new Oda(){ OdaNo=104,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="100TL" },
                        new Oda(){ OdaNo=105,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="100TL" },
                        new Oda(){ OdaNo=106,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="100TL" },
                    });
                    break;
                case OtelTipi.ButikOtel:
                    OdalarList.AddRange(new List<Oda>()
                    {
                        new Oda(){ OdaNo=100,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=false,Fiyat="300TL" },
                        new Oda(){ OdaNo=101,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=false,Fiyat="300TL" },
                        new Oda(){ OdaNo=102,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=false,Fiyat="300TL" },
                        new Oda(){ OdaNo=103,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=false,Fiyat="300TL" },
                        new Oda(){ OdaNo=104,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=false,Fiyat="300TL" },
                        new Oda(){ OdaNo=105,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=false,Fiyat="300TL" },
                        new Oda(){ OdaNo=106,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=false,Fiyat="300TL" },

                        new Oda(){ OdaNo=100,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=false,Fiyat="300TL" },
                        new Oda(){ OdaNo=101,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=false,Fiyat="300TL" },
                        new Oda(){ OdaNo=102,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=false,Fiyat="300TL" },
                        new Oda(){ OdaNo=103,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=false,Fiyat="300TL" },
                        new Oda(){ OdaNo=104,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=false,Fiyat="300TL" },
                        new Oda(){ OdaNo=105,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=false,Fiyat="300TL" },
                        new Oda(){ OdaNo=106,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=false,Fiyat="300TL" },

                    });
                    break;
                case OtelTipi.IkiYildizliOtel:
                    OdalarList.AddRange(new List<Oda>()
                    {
                        new Oda(){ OdaNo=100,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL"},
                        new Oda(){ OdaNo=101,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=102,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=103,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=104,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=105,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=106,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=107,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=108,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=109,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },

                        new Oda(){ OdaNo=100,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=101,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=102,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=103,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=104,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=105,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=106,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=107,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=108,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=109,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },


                        new Oda(){ OdaNo=100,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=101,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=102,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=103,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=104,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=105,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=106,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=107,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=108,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=109,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },



                    });
                    break;
                case OtelTipi.UcYildizliOtel:
                    OdalarList.AddRange(new List<Oda>()
                    {
                        new Oda(){ OdaNo=100,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL"},
                        new Oda(){ OdaNo=101,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=102,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=103,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=104,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=105,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=106,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=107,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=108,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=109,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },

                        new Oda(){ OdaNo=100,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=101,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=102,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=103,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=104,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=105,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=106,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=107,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=108,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=109,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },


                        new Oda(){ OdaNo=100,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=101,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=102,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=103,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=104,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=105,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=106,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=107,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=108,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=109,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },



                    });
                    break;
                case OtelTipi.DortYildizliOtel:
                    OdalarList.AddRange(new List<Oda>()
                    {
                        new Oda(){ OdaNo=100,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL"},
                        new Oda(){ OdaNo=101,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=102,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=103,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=104,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=105,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=106,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=107,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=108,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=109,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },

                        new Oda(){ OdaNo=100,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=101,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=102,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=103,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=104,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=105,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=106,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=107,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=108,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=109,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },


                        new Oda(){ OdaNo=100,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=101,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=102,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=103,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=104,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=105,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=106,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=107,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=108,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=109,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },



                    });
                    break;
                case OtelTipi.BesYildizliOtel:
                    OdalarList.AddRange(new List<Oda>()
                    {
                        new Oda(){ OdaNo=100,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL"},
                        new Oda(){ OdaNo=101,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=102,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=103,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=104,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=105,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=106,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=107,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=108,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },
                        new Oda(){ OdaNo=109,TekkisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="500TL" },

                        new Oda(){ OdaNo=100,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=101,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=102,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=103,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=104,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=105,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=106,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=107,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=108,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },
                        new Oda(){ OdaNo=109,CiftKisilikOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="300TL" },


                        new Oda(){ OdaNo=100,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=101,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=102,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=103,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=104,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=105,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=106,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=107,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=108,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },
                        new Oda(){ OdaNo=109,IkizYatakliOda=true,DenizManzarasi=true,HavuzManzarasi=true,Fiyat="400TL" },



                    });
                    break;
                default:
                    break;
            }
            return OdalarList;
        }

        public bool RezervasyonDurumu(Oda _oda, DateTime girisTarihi)
        {
            var state = _oda.Rezervasyonlar.Any(x => x.GirisTarihi.Date == girisTarihi.Date);

            if (!state)
            {
                state = _oda.Rezervasyonlar.Any(x => x.GirisTarihi < girisTarihi.Date && x.CikisTarihi.Date > girisTarihi);
            }

            return state;
        }

        public void RezervasyonYap(Oda _oda, Rezervasyon _rez)
        {
            _oda.Rezervasyonlar.Add(_rez);
        }


        public bool RezervasyonIptal(Rezervasyon _rez)
        {
            var _oda = OdalarList.FirstOrDefault(x => x.OdaNo == _rez.OdaNumarasi);
            if (_oda != null)
            {
                _oda.Rezervasyonlar.Remove(_rez);
                return true;
            }
            else
            {
                return false;
            }
        }


        public float DolulukOrani(DateTime girisTarihi)
        {
            int count = 0;
            foreach (var oda in OdalarList)
            {
                if (oda.Rezervasyonlar.Any(y => y.GirisTarihi.Date == girisTarihi.Date))
                {
                    count++;
                }
            }

            return (count / (float)OdalarList.Count) * 100;
        }
    }
}
}
