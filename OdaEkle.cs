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
    public partial class OdaEkle : Form
    {
        public OdaEkle()
        {
            InitializeComponent();
        }

        private void OdaEkle_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();//formu temizleme
            foreach (Sehir sehir in Sistem.sehirList.Values)
            {
                comboBox1.Items.Add(sehir.SehirAd);//sehir lisesine bakıp item ekleme
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool denizmanzarasi = false, tv = false, klima = false, minibar = false, havuzmanzarasi = false, internet = false;//basta tum özellikler false
            if (checkBox1.Checked)//seçiliyse deniz manzaarası true
                denizmanzarasi = true;
            if (checkBox2.Checked)//seçiliyse tv true
                 tv = true;
            if (checkBox3.Checked)//seçiliyse klima true
                klima = true;
            if (checkBox4.Checked)//seçiliyse minibar true
                minibar = true;
            if (checkBox5.Checked)//seçiliyse havuzmanzarasi true
                havuzmanzarasi = true;
            if (checkBox6.Checked)//seçiliyse internet true
                internet = true;
            int oda = 0;///casede kullancam
            if (radioButton1.Checked)
                oda = 1;
            else if (radioButton2.Checked)
                oda = 2;
            else if (radioButton3.Checked)
                oda = 3;
            int id = 0;
            try
            {
                if (comboBox1.Text == "" || textBox1.Text == "" || comboBox2.Text=="")//bosssa 
                {
                    throw new Exception("Bos Kısımları Doldurun");//hata verdirme
                }
                switch (oda)
                {
                    case 1://radyo butonu 1 seciliyse
                        Oda tekKisilik = new TekKisilikOda(Convert.ToInt32(textBox1.Text), denizmanzarasi, tv, klima, minibar, havuzmanzarasi, internet);//tek kisilik oda olurstutru
                        foreach (Otel otel in Sistem.sehirList[comboBox1.SelectedIndex].OtellerList.Values)//oteller listesine bakar
                        {
                            if (otel.OtelAd == comboBox2.SelectedItem)
                            {
                                id = otel.OtelId;
                            }
                        }
                        tekKisilik.Fiyat += Sistem.sehirList[comboBox1.SelectedIndex].OtellerList[id].Yildiz * 100;//fiyat belirleme
                        Sistem.sehirList[comboBox1.SelectedIndex].OtellerList[id].OdaEkle(tekKisilik);//odayı ekleme
                        break;
                    case 2://radyo butonu 2 seciliyse
                        Oda ciftKisilik = new CiftKisilikOda(Convert.ToInt32(textBox1.Text), denizmanzarasi, tv, klima, minibar, havuzmanzarasi, internet);//cift kisilik oda olusturma
                        foreach (Otel otel in Sistem.sehirList[comboBox1.SelectedIndex].OtellerList.Values)//oteller listesine bak
                        {
                            if (otel.OtelAd == comboBox2.SelectedItem)
                            {
                                id = otel.OtelId;
                            }
                        }
                        ciftKisilik.Fiyat += Sistem.sehirList[comboBox1.SelectedIndex].OtellerList[id].Yildiz * 150;//fiyat belirle
                        Sistem.sehirList[comboBox1.SelectedIndex].OtellerList[id].OdaEkle(ciftKisilik);//odayı ekle
                        break;
                    case 3://radyo butonu 3 seciliyse
                        Oda ikizyatakli = new İkizYatakliOda(Convert.ToInt32(textBox1.Text), denizmanzarasi, tv, klima, minibar, havuzmanzarasi, internet);//ikiz yataklı oda oluşturma
                        foreach (Otel otel in Sistem.sehirList[comboBox1.SelectedIndex].OtellerList.Values)//oteller listesine bakma
                        {
                            if (otel.OtelAd == comboBox2.SelectedItem)
                            {
                                id = otel.OtelId;
                            }
                        }
                        ikizyatakli.Fiyat += Sistem.sehirList[comboBox1.SelectedIndex].OtellerList[id].Yildiz * 200;//fyat ayarlama
                        Sistem.sehirList[comboBox1.SelectedIndex].OtellerList[id].OdaEkle(ikizyatakli);//odayı ekleme
                        break;

                }
            }
            catch(Exception ex)//hata mesajı gösterme
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            foreach (Otel otel in Sistem.sehirList[comboBox1.SelectedIndex].OtellerList.Values)//o sehirdeki otellere ulaşma
            {
                comboBox2.Items.Add(otel.OtelAd);//otele ekleme
            }
        }
    }
}
