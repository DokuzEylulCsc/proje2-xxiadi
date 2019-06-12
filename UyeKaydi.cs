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
    public partial class UyeKaydi : Form 
    {
        Musteri musteri;
        Sistem sistem = Sistem.GetInstance();

        public UyeKaydi()
        {
            InitializeComponent();
        }

       

        private void UyeKaydi_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int control = 1;
            //while(control==0)
               // {
                
                try
                {
                    if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")//textboxlar boş işe
                    {


                        musteri = new Musteri(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt64(textBox4.Text), textBox5.Text);//kullanici oluştur
                        foreach (Musteri m in Sistem.kullaniciList.Values)//kullanici listesindeki musterilere bak
                        {
                            if (m.KullaniciAdi == musteri.KullaniciAdi)// varsa hata
                            {
                               
                                throw new Exception("Kullanici adi kullanilmakta.");
                            }

                        }
                        
                    }
                    else// eksik veya hatalıysa
                    {
                        throw new Exception("Kullanici bilgilerini düzgün girin");
                    }
                }
                catch (FormatException)//formatları yanlış girdiyse
                {
                    control = 0;
                    MessageBox.Show("Girişte Format Hatası");
                }
                catch (Exception ex)///hata mesajlarını gösterme
                {
                    control = 0;
                    MessageBox.Show(ex.Message);
                }
            // }
            if (control == 1)
            {
                Sistem.kullaniciList.Add(musteri.KullaniciId, musteri);//sisteme kullanici ekleme
                Yazdirma.Yazma(musteri);
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
