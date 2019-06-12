using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje2
{
    public partial class From1 : Form
    {
       
        ////Dictionary<string, Kullanici> kullaniciList = new Dictionary<string, Kullanici>();
        ////public static string ad, sifre, email;
        ////public static int telefon;
        public From1()
        {
            
            InitializeComponent();
        }

        public static string KullaniciID;

        private void button1_Click(object sender, EventArgs e)
        {
            UyeKaydi uyekaydi = new UyeKaydi();//uye kaydı formunu açma
            uyekaydi.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void From1_Load(object sender, EventArgs e)
        {
            Yonetim yonetici = new Yonetim(1,"Damla","1234",05384942554,"damla.ipci@hotmail.com");//yoneticinin sistem içindeki bilgileri
            Sistem.yoneticiList.Add(yonetici.KullaniciId, yonetici);//yöneticiyi ekler
            
            Sistem sistem = new Sistem();
            //string[] sehiradlari = new string[5] { "İstanbul", "İzmir", "Bursa", "Antalya", "Ankara" };
            //for(int i = 0; i < 5; i++)
            //{
            //    Sehir sehir = new Sehir(i, sehiradlari[i]);
            //    sistem.SehirEkle(sehir);
            //}
           Yazdirma.Okuyucu();//forma girdiğinde musteri okuma
            Yazdirma.OtelOkuma();//otel okuma
            //sistem.SehirEkle(0, "Istanbul");
           

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int control = 0;
            try
            {
                KullaniciID = textBox1.Text;//kullanici iid textbox  1 de alma
                if (textBox1.Text == "" || textBox2.Text == "")//bossa hata mesajı
                {
                    throw new Exception("Lütfen Boş Yerleri Doldurun");
                }
                else
                {
                
                foreach (Musteri m in Sistem.kullaniciList.Values)//musterilere bakma
                {
                    if (m.KullaniciAdi == textBox1.Text && m.Sifre == textBox2.Text)//eger girilen değerler tutarsa
                    {
                        control = 1;
                        OtelSecim otelsecim = new OtelSecim();//otel secimi aç
                        this.Hide();
                        otelsecim.Show();
                    }
                }

                }
                if(control==0)
                {
                    throw new Exception("Bilgileri doğru giriniz");//control 0 ise hata mesajı alır
                }
            }
            catch(Exception ex)///yakalanan mesajı yazırma
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)//yoneticiniin giriş yapacağı buton
        {
            try
            {

                int control = 0;
                string ad = textBox1.Text;
                string sifre = textBox2.Text;
                if(textBox1.Text==""||textBox2.Text=="")//bossa 
                {
                    throw new Exception("Eksik Kısımları Dolurunuz.");//hata yakalatma
                }
                foreach (Yonetim yonetici in Sistem.yoneticiList.Values)//yoneyici listesine bak
                {
                    if (yonetici.KullaniciAdi == ad && yonetici.Sifre == sifre)// tutarsa
                    {
                        control = 1;
                        Yonetici yonetic = new Yonetici();//yonetici formunu aç
                        yonetic.Show();
                    }
                    
                }
                if(control==0)//control 1 olmayıp yönetici tutmadıysa hata yakalama
                { throw new Exception("Yonetici Yok"); }
            }
            catch(Exception ex)//hataları yazdırma
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    OtelSecim otelsec = new OtelSecim();
        //    otelsec.Show();
        //}

        private void button4_Click_1(object sender, EventArgs e)//bilgileri güncelleme metodu
        {
            try
            {
               if(textBox1.Text==""|| textBox2.Text == "")//bosssa
                { throw new Exception("Bos Bırakmayın."); }//hata

                foreach (Musteri musteri in Sistem.kullaniciList.Values)//musterilere bakma listeden
                {
                    if (musteri.KullaniciAdi == textBox1.Text && musteri.Sifre == textBox2.Text)///tutarsa
                    {
                        Sistem.ID = musteri.KullaniciId;
                        BilgiGuncelleme bilgiGuncelleme = new BilgiGuncelleme();//guncelleme sayfasını aç
                        bilgiGuncelleme.Show();
                    }
                }
            }
            catch(Exception ex)//hata mesajı verme
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
