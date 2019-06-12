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
    public partial class BilgiGuncelleme : Form
    {
        public BilgiGuncelleme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text==""|| textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" )//textboxlar boş işe
                {
                    throw new Exception("Boslukları Doldurun");// hata yakala
                }
                foreach (Musteri musteri in Sistem.kullaniciList.Values)//kullanici listesindeki müsterilere bakma
                {
                    if (Sistem.ID == musteri.KullaniciId)//sistemdeki müsteri ile aynıysa
                    {
                        musteri.KullaniciAdi = textBox1.Text;//ad güncelleme
                        musteri.Sifre = textBox2.Text;//sifre güncelleme
                        musteri.Telefon = Convert.ToInt64(textBox3.Text);//telefon güncelleme
                        musteri.Email = textBox4.Text;//email güncelleme
                    }
                }
                


            }
            catch(Exception ex)//hata mesajı yakalayıp yazdırma
            {
                MessageBox.Show(ex.Message);
            }
            Yazdirma.Guncelleme();
        }

        private void BilgiGuncelleme_Load(object sender, EventArgs e)
        {

        }
    }
}
