using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _173311068_abc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            // Gerekli tanımlamalar yapılıyor
            int koloniBoyutu = (int)nudKoloni.Value;

            int altSinir = (int)nudAlt.Value;
            int ustSinir = (int)nudUst.Value;
            int cevrimSayisi = (int)nudCevrim.Value;
            int denemeSayisi = (int)nudDeneme.Value;

            chartEniyi.Series["x1"].Points.Clear();
            chartEniyi.Series["x2"].Points.Clear();
            chartFx.Series["fx"].Points.Clear();
            textBox1.Text = "";

            // Yapay arı kolonisi isimli bir sınıf oluşturuluyor ve formdan verilen bilgiler gönderiliyor.
            YapayAriKolonisi yapayAriKolonisi = new YapayAriKolonisi(koloniBoyutu, altSinir,ustSinir, cevrimSayisi,denemeSayisi);

            for(int i =0;i < 25; i++)
            {
                chartEniyi.Series["x1"].Points.Add(yapayAriKolonisi.eniyiX1List[i]);
                chartEniyi.Series["x2"].Points.Add(yapayAriKolonisi.eniyiX2List[i]);

                chartFx.Series["fx"].Points.Add(yapayAriKolonisi.fxDegerleri[i]);

               // textBox1.Text += "x1 : " + yapayAriKolonisi.besin.besinler[i].x1 + " x2 : " + yapayAriKolonisi.besin.besinler[i].x2 + " \n ";
                textBox1.Text += "x1 : " + yapayAriKolonisi.eniyiX1List[i] + " | x2 : " + yapayAriKolonisi.eniyiX2List[i] + " | fx : " + yapayAriKolonisi.fxDegerleri[i] + " | fit : " + yapayAriKolonisi.fitDegerleri[i] + Environment.NewLine;
            } 

        }
    }
}
