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
    public partial class Yonetici : Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OtelEkle otelEkle = new OtelEkle();//otel ekleme formu açılsın
            otelEkle.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OdaEkle odaekle = new OdaEkle();//oda ekleme butonu acılsın
            odaekle.Show();
        }

        private void Yonetici_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)//sehiri listboxa ekleme
            {
                listBox1.Items.Add(Sistem.sehirList[i].SehirAd);
            }
            //listBox1.Items.Add(Sistem.sehirList[])
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            int id=0;
            foreach (Otel otel in Sistem.sehirList[listBox1.SelectedIndex].OtellerList.Values)//oteller listesinden alıp lşstboxa yazdırma
            {
                if (otel.OtelAd == listBox2.SelectedItem)
                {
                    id = otel.OtelId;
                }
            }
            foreach (Oda oda in Sistem.sehirList[listBox1.SelectedIndex].OtellerList[id].OdalarList.Values)//otellerden odaları açma
            {
                listBox3.Items.Add(oda.OdaNo);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach(Otel otel in Sistem.sehirList[listBox1.SelectedIndex].OtellerList.Values)//sehirlerden otelleri gösterme
            {
                listBox2.Items.Add(otel.OtelAd);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //foreach(Otel otel in Sistem.sehirList[])

            Yazdirma.Yazma();

        }
    }
}
