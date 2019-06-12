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
    public partial class OtelSecim : Form
    {
       

        public OtelSecim()
        {
            InitializeComponent();
        }
        Otel otel;
        private void button1_Click(object sender, EventArgs e)
        {
            var date1 = dateTimePicker1.Value;
            var date2 = dateTimePicker2.Value;

            
            int yildiz3 = 0,yildiz4=0,yildiz5=0 ;//basta yok
            bool tekyatak = false, ciftyatak = false, ikizyatak = false;
            bool butik = false, pansiyon = false, tatilkoyu = false;
            bool havuz=false, spa=false, sporsalonu=false, klima=false, tv=false, internet=false, minibar=false, havuzmanzarasi=false, denizmanzarasi=false;
            //ozelliklerin hepsi basta false

            //iflerin içindekiler filtrelemeler
            if (checkBox1.Checked)
                havuz = true;//seciliyse havuz eklenir
            if (checkBox2.Checked)
                spa = true;//seciliyse spa eklenir
            if (checkBox3.Checked)
                sporsalonu = true;//seciliyse sporsalonu eklenir
            if (checkBox4.Checked)
                klima = true;//seciliyse klima eklenir
            if (checkBox5.Checked)
                tv = true;//seciliyse tv eklenir
            if (checkBox6.Checked)
                internet = true;//seciliyse internet eklenir
            if (checkBox7.Checked)
                minibar = true;//seciliyse minibar eklenir
            if (checkBox8.Checked)
                havuzmanzarasi = true;//seciliyse havuz manzarasi eklenir
            if (checkBox9.Checked)
                denizmanzarasi = true;//seciliyse deniz manzarasi eklenir
            if (checkBox10.Checked)
                butik = true;//seciliyse butik otel eklenir
            if (checkBox11.Checked)
                pansiyon = true;//seciliyse pansiyon eklenir
            if (checkBox12.Checked)
                tatilkoyu = true;//seciliyse tatil koyu eklenir
            if (checkBox13.Checked)
                yildiz3 = 3;//seciliyse yıldız sayısı 3 olur
            if (checkBox14.Checked)
                yildiz4 = 4;
            if (checkBox15.Checked)
                yildiz5 = 5;
            if (checkBox16.Checked)
                tekyatak = true;//seciliyse tek yaatak eklenir
            if (checkBox17.Checked)
                ciftyatak = true;//seciliyse cifttyatak eklenir
            if (checkBox18.Checked)
                ikizyatak = true;////seciliyse ikizyatak eklenir

            double minfiyat = Convert.ToDouble(textBox1.Text);
            double maxfiyat = Convert.ToDouble(textBox2.Text);     

            foreach (Otel otel in Sistem.sehirList[comboBox1.SelectedIndex].OtellerList.Values)//oteller listesi
            {
                if ((otel.butikotel == butik || otel.pansiyon == pansiyon || otel.tatilkoyu == tatilkoyu))//otellerden biri veya bazıları seciliyse
                    
                {

                    foreach (Oda odacık in Sistem.sehirList[comboBox1.SelectedIndex].OtellerList[otel.OtelId].OdalarList.Values)//odalara bak
                    {
                        if ((odacık.DenizManzarasi == denizmanzarasi || odacık.HavuzManzarasi == havuzmanzarasi || odacık.Internet == internet || odacık.Klima == klima ||
                            odacık.Minibar == minibar || odacık.Tv == tv)&&(odacık.ciftkisilikoda==ciftyatak||odacık.ikizyataklioda==ikizyatak||odacık.tekkisilikoda==tekyatak))//ozelliklereden bazıları veya hepsi seciliyse
                        {
                            if (odacık.Fiyat >= minfiyat && odacık.Fiyat <= maxfiyat)//odanın fiyatı minden büyük maxdan kücükse
                            {
                                BulunanOteller.Items.Add(otel.OtelAd + " -" + otel.Yildiz + " -" + otel.GetType() + " -Havuz= " + otel.Havuz + " -Spa= " + otel.Spa + "\n -SporSalonu=" + otel.SporSalonu + " -HavuzManzarasi=" +
                                    odacık.HavuzManzarasi + " -İnternet=" + odacık.Internet + " -Klima=" + odacık.Klima + " -Minibar=" + odacık.Minibar + " TV=" + odacık.Tv + " -denizmanzarasi=" + odacık.DenizManzarasi + " -Odano: " + odacık.OdaNo +
                                    " -Fiyat" + odacık.Fiyat+" -İkiz yataklı="+odacık.ikizyataklioda+" -tekkisilik="+odacık.tekkisilikoda+" -ciftkilisik="+odacık.ciftkisilikoda);
                                ///// listboxa hepsini yazdırma
                            }
                        }
                    }
                }
                

                
                

            }
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker2.Value.AddDays(1);//date time
        }

        private void OtelSecim_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
