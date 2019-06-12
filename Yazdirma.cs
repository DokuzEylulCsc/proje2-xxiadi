using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proje2
{
    class Yazdirma
    {
        static Otel otel;
        static Oda oda;
        public static StreamWriter yazici;
        public static FileStream yazicifs;
        public static StreamReader okuyucu;
        public static FileStream okuyucufs;
        public static void Yazma(Musteri musteri)//musteri için yazdırma
        {

            
            yazicifs = new FileStream(@"Liste.txt", FileMode.Append, System.IO.FileAccess.Write);///dosyayı acıp yazıyor
            yazici = new StreamWriter(yazicifs);
            yazici.WriteLine(musteri.KullaniciId + ";" + musteri.KullaniciAdi+ ";" + musteri.Sifre+ ";"+musteri.Telefon+";"+musteri.Email);//ad ,id sifre,telefon,mailleri texte yazdırma
            
           
            yazici.Flush();
            yazici.Close();
            yazicifs.Close();
        }
        public static void Guncelleme()//içeride bulunan kullanıcıların bilgilerini güncellediğinde çalışır
        {
            yazicifs = new FileStream(@"Liste.txt", FileMode.Open, System.IO.FileAccess.Write);//açma ve yazma
            yazici = new StreamWriter(yazicifs);
            foreach(Musteri musteri in Sistem.kullaniciList.Values)//kullanici listesine bakar güncellemek için
            {
                yazici.WriteLine(musteri.KullaniciId + ";" + musteri.KullaniciAdi + ";" + musteri.Sifre + ";" + musteri.Telefon + ";" + musteri.Email);//müsteri bilgilerini yazma

            }


            yazici.Flush();
            yazici.Close();
            yazicifs.Close();
        }
        public static void Okuyucu()
        {
           
            okuyucufs = new FileStream(@"Liste.txt", FileMode.Open, System.IO.FileAccess.Read);//programı kapatıp tekrar açtığımızda eklenen bilgileri tekrarr alır
            okuyucu = new StreamReader(okuyucufs);
            string satir = okuyucu.ReadLine();//satırları alır
            while (satir!=null) //satırlar boş değilse
            {
                string[] kisim = satir.Split(';');//noktalı virgülleri split eder
                Musteri musteri = new Musteri(Convert.ToInt32(kisim[0]),kisim[1],kisim[2], Convert.ToInt64(kisim[3]),kisim[4]);///musteriye alır
                Sistem.kullaniciList.Add(musteri.KullaniciId,musteri);//sisteme kullanıcıları ekler
                satir = okuyucu.ReadLine();


            }
            okuyucu.Close();
            okuyucufs.Close();
        }
        public static void Yazma()//oteller için yazdırma
        {
            yazicifs = new FileStream(@"Oteller.txt", FileMode.OpenOrCreate, System.IO.FileAccess.Write);//dosyayı açıp yazma
            yazici = new StreamWriter(yazicifs);

            foreach(Sehir sehir in Sistem.sehirList.Values)//sehirlistesine bakar
            {
                yazici.WriteLine(sehir.SehirID+";"+sehir.SehirAd+";"+sehir.OtellerList.Count);//sehir id ve ad ve bulunan otel sayısı
                foreach(Otel otel in Sistem.sehirList[sehir.SehirID].OtellerList.Values)//oteller listesine bakar
                {
                    yazici.WriteLine(otel.OtelId + ";" + otel.OtelAd + ";" + otel.Yildiz + ";" + otel.Spa + ";" + otel.Havuz + ";" + otel.SporSalonu + ";" +otel.butikotel+";"+
                        otel.pansiyon+";"+otel.tatilkoyu+";"+Convert.ToInt32(otel.OdalarList.Count));//otelin tüm özelliklerini oda sayısıyla beraber alır
                    foreach (Oda oda in Sistem.sehirList[sehir.SehirID].OtellerList[otel.OtelId].OdalarList.Values)//otellerin içindeki odalara bakar
                    {
                        yazici.WriteLine(oda.OdaNo + ";" + oda.DenizManzarasi + ";" + oda.Tv + ";" + oda.Klima + ";" +
                            oda.Minibar + ";" + oda.HavuzManzarasi + ";" +oda.Internet + ";" + oda.Fiyat + ";" +oda.tekkisilikoda +
                            ";" + oda.ciftkisilikoda + ";" + oda.ikizyataklioda);//odaların tüm özelliklerini true false şeklinde alır
                    }
                }
            }
            //yazici.WriteLine(otel.OtelId+ ";" + otel.OtelAd+ ";" + otel.Yildiz+ ";" + otel.Spa+ ";" +otel.Havuz+";"+otel.SporSalonu+";"+Convert.ToInt32(otel.OdalarList.Count));
            //for(int i=0;i<otel.OdalarList.Count;i++)
            //{
            //    yazici.WriteLine(otel.OdalarList[i].OdaNo + ";" + otel.OdalarList[i].DenizManzarasi + ";" + otel.OdalarList[i].Tv + ";" + otel.OdalarList[i].Klima + ";" +
            //        otel.OdalarList[i].Minibar + ";" + otel.OdalarList[i].HavuzManzarasi + ";" + otel.OdalarList[i].Internet + ";" + otel.OdalarList[i].Fiyat+";"+ otel.OdalarList[i].tekkisilikoda+
            //        ";"+ otel.OdalarList[i].ciftkisilikoda+";"+ otel.OdalarList[i].ikizyataklioda);
            //}
            
            yazici.Flush();
            yazici.Close();
            yazicifs.Close();
        }
        public static void OtelOkuma()//otelleri okuma
        {
           
            okuyucufs = new FileStream(@"Oteller.txt", FileMode.Open, System.IO.FileAccess.Read);///oteller listesini açıp okkuma
            okuyucu = new StreamReader(okuyucufs);
            string satir = okuyucu.ReadLine();
            while (satir != null)//satırlar boş değilse
            {
                string[] kisim = satir.Split(';');//noktalı virgülleri splitler
                Sehir sehir = new Sehir(Convert.ToInt32(kisim[0]),kisim[1]);//id ve adı alır
                Sistem.sehirList.Add(sehir.SehirID, sehir);//sehir listesine ekler
                if (kisim[2] != "0") {

                    for (int i = 0; i < Convert.ToInt32(kisim[2]); i++)
                    {
                        //satir = okuyucu.ReadLine();
                        string[] otelozellik = okuyucu.ReadLine().Split(';');
                        if (otelozellik[6] == "True")//butik otel true ise
                        {
                            otel = new ButikOtel(Convert.ToInt32(otelozellik[0]), otelozellik[1], Convert.ToInt32(otelozellik[2]), Convert.ToBoolean(otelozellik[3]), Convert.ToBoolean(otelozellik[4]),
                                Convert.ToBoolean(otelozellik[5]));//özellikler

                        }
                        else if (otelozellik[7] == "True")//pansiyon true ise
                        {
                            otel = new Pansiyon(Convert.ToInt32(otelozellik[0]), otelozellik[1], Convert.ToInt32(otelozellik[2]), Convert.ToBoolean(otelozellik[3]), Convert.ToBoolean(otelozellik[4]),
                               Convert.ToBoolean(otelozellik[5]));//özellikleri
                        }
                        else if (otelozellik[8] == "True")// tatilköyü
                        {
                            otel = new TatilKöyü(Convert.ToInt32(otelozellik[0]), otelozellik[1], Convert.ToInt32(otelozellik[2]), Convert.ToBoolean(otelozellik[3]), Convert.ToBoolean(otelozellik[4]),
                               Convert.ToBoolean(otelozellik[5]));//özellikleri

                        }
                        Sistem.sehirList[sehir.SehirID].OtellerList.Add(otel.OtelId, otel);//sistemin içindeki sehir listesine otelleri okur
                        if (otelozellik[9] != "0")
                        {
                            for (int j = 0; j < Convert.ToInt32(otelozellik[9]); j++)
                            {

                                //satir = okuyucu.ReadLine();
                                string[] odaozelligi = okuyucu.ReadLine().Split(';');
                                if (odaozelligi[8] == "True")//tek kisilik oda true ise
                                {
                                    oda = new TekKisilikOda(Convert.ToInt32(odaozelligi[0]), Convert.ToBoolean(odaozelligi[1]), Convert.ToBoolean(odaozelligi[2]), Convert.ToBoolean(odaozelligi[3]),
                                        Convert.ToBoolean(odaozelligi[4]), Convert.ToBoolean(odaozelligi[5]), Convert.ToBoolean(odaozelligi[6]));//özelliklerini alır
                                }

                                else if (odaozelligi[9] == "True")//cift kislik oda true ise özelliklerinş alır
                                {
                                    oda = new CiftKisilikOda(Convert.ToInt32(odaozelligi[0]), Convert.ToBoolean(odaozelligi[1]), Convert.ToBoolean(odaozelligi[2]), Convert.ToBoolean(odaozelligi[3]),
                                        Convert.ToBoolean(odaozelligi[4]), Convert.ToBoolean(odaozelligi[5]), Convert.ToBoolean(odaozelligi[6]));
                                }
                                else if (odaozelligi[10] == "True")//ikiz yataklı oda true ise özelliklerini texten alır
                                {
                                    oda = new İkizYatakliOda(Convert.ToInt32(odaozelligi[0]), Convert.ToBoolean(odaozelligi[1]), Convert.ToBoolean(odaozelligi[2]), Convert.ToBoolean(odaozelligi[3]),
                                        Convert.ToBoolean(odaozelligi[4]), Convert.ToBoolean(odaozelligi[5]), Convert.ToBoolean(odaozelligi[6]));
                                }

                                Sistem.sehirList[sehir.SehirID].OtellerList[otel.OtelId].OdalarList.Add(oda.OdaNo, oda);//odalar listeme ekler
                            }
                        }
                    
                        

                    }

                }


                satir = okuyucu.ReadLine();
                
                
              


            }
            okuyucu.Close();
            okuyucufs.Close();
        }

    }
}
