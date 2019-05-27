using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otelprojesii
{
    public partial class Uyekayiti : Form
    {
        Sistem sistem = Sistem.GetInstance();
        public Uyekayiti()
        {
            InitializeComponent();
        }

        private void Uyekayiti_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")//textboxlar boş işe
                {

                    //Kullanici kullanici = new Kullanici(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), textBox4.Text);//kullanici oluştur
                    //sistem.KullaniciEkleme(kullanici);//sisteme kullanici ekleme
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Girişte Format Hatası");
            }
            catch (Exception)
            {
                MessageBox.Show("Kullanici Bilgilerini Düzgün Giriniz");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
