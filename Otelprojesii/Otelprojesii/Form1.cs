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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string KullaniciID;
        private void Form1_Load(object sender, EventArgs e)
        {
            Sistem sistem = new Sistem();
            string[] sehiradlari = new string[5] { "İstanbul", "İzmir", "Bursa", "Antalya", "Ankara" };
            for (int i = 0; i < 5; i++)
            {
                Sehir sehir = new Sehir(i, sehiradlari[i]);
                sistem.SehirEkle(sehir);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uyekayiti uyekayiti = new Uyekayiti();
            uyekayiti.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Yonetim yonetici = new Yonetim();
            yonetici.Show();
        }
    }
}
