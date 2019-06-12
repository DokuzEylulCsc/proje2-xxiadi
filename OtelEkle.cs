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
    public partial class OtelEkle : Form
    {
        public OtelEkle()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OtelEkle_Load(object sender, EventArgs e)
        {
            foreach(Sehir sehir in Sistem.sehirList.Values)//sehir listesini tutma
            {
                comboBox1.Items.Add(sehir.SehirAd);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            bool havuz = false,spa = false,sporsalonu = false;//ozellikler basta false alınır
            int yildiz = 0;
            if (checkBox1.Checked)
                havuz = true;//isaretliyse havuz eklenir
            if (checkBox2.Checked)
                spa = true;//işaretliyse spa eklenir
            if (checkBox3.Checked)
                sporsalonu = true;//işaretliyse sporsalonu eklenir
            int tip = 0;//casede kullanma
            if (radioButton1.Checked)
                tip = 1;//pansiyon için
            else if (radioButton2.Checked)
                tip = 2;//butikotel için
            else if (radioButton3.Checked)          //if e çok gerek yok aslında zaten ilk 2 durumu karşılamıyosa 3. radiobutton seçilidir
                tip = 3;//tatil köyü için
            if (radioButton4.Checked)
                yildiz = 3;
            else if (radioButton5.Checked)
                yildiz = 4;
            else if (radioButton6.Checked)
                yildiz = 5;
            try
            {
                if (comboBox1.Text == "" || textBox1.Text == ""||textBox2.Text=="")//bossa
                {
                    throw new Exception("Bos Kısımları Doldurun");//hata yakalatma
                }
                    switch (tip)
                {
                    case 1://radio button 1 seciliyse
                        Pansiyon pansiyon = new Pansiyon(Convert.ToInt32(textBox1.Text), textBox2.Text, yildiz, spa, havuz, sporsalonu);//pansiyon oluşturma

                        Sistem.sehirList[comboBox1.SelectedIndex].OtelEkle(pansiyon);////oteli sehre ekle

                        break;
                    case 2:
                        ButikOtel butik = new ButikOtel(Convert.ToInt32(textBox1.Text), textBox2.Text, yildiz, spa, havuz, sporsalonu);//butik oluşturma
                        Sistem.sehirList[comboBox1.SelectedIndex].OtelEkle(butik);//oteli sehre ekleme
                        break;
                    case 3:
                        TatilKöyü tatilKöyü = new TatilKöyü(Convert.ToInt32(textBox1.Text), textBox2.Text, yildiz, spa, havuz, sporsalonu);//tatil koyu oluşturma
                        Sistem.sehirList[comboBox1.SelectedIndex].OtelEkle(tatilKöyü);//oteli sehre ekleme
                        break;
                }
               
            }
            catch(Exception ex)//hata mesajı
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
