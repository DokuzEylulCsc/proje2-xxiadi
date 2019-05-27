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
    public partial class OtelEkle : Form
    {
        public OtelEkle()
        {
            InitializeComponent();
        }

        private void OtelEkle_Load(object sender, EventArgs e)
        {
            foreach (Sehir sehir in Sistem.sehirList.Values)
            {
                comboBox1.Items.Add(sehir.SehirAd);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool havuz = false, spa = false, sporsalonu = false;
            int yildiz = 0;
            if (checkBox1.Checked)
                havuz = true;
            if (checkBox2.Checked)
                spa = true;
            if (checkBox3.Checked)
                sporsalonu = true;
            int tip = 0;
            if (radioButton1.Checked)
                tip = 1;
            else if (radioButton2.Checked)
                tip = 2;
            else if (radioButton3.Checked)          //if e çok gerek yok aslında zaten ilk 2 durumu karşılamıyosa 3. radiobutton seçilidir
                tip = 3;
            if (radioButton4.Checked)
                yildiz = 3;
            else if (radioButton5.Checked)
                yildiz = 4;
            else if (radioButton6.Checked)
                yildiz = 5;
            switch (tip)
            {
                case 1:
                    OtelTipi.Pansiyon

               pansiyon = new OtelTipi.Pansiyon(Convert.ToInt32(textBox1.Text), textBox2.Text, yildiz, spa, havuz, sporsalonu);
                    Sistem.sehirList[comboBox1.SelectedIndex].OtelEkle(pansiyon);
                    //Sistem.sehirList[seh]
                    break;
                case 2:
                    ButikOtel butik = new ButikOtel(Convert.ToInt32(textBox1.Text), textBox2.Text, yildiz, spa, havuz, sporsalonu);
                    Sistem.sehirList[comboBox1.SelectedIndex].OtelEkle(butik);
                    break;

                case 3:
                    TatilKöyü tatilKöyü = new TatilKöyü(Convert.ToInt32(textBox1.Text), textBox2.Text, yildiz, spa, havuz, sporsalonu);
                    Sistem.sehirList[comboBox1.SelectedIndex].OtelEkle(tatilKöyü);
                    break;
            }
    }
}
