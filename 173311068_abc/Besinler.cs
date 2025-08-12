using System;

namespace _173311068_abc
{
    class Besinler
    {
        public double x1;
        public double x2;
        public double fx;
        public double fit;

        public double olasilikDegeri;

        public int iyilestirilememe = 0; // İyileştirilmediğinde artırılacaktır
        public static readonly Object kilitlemeNesnesi = new Object();
        public static readonly Random rnd = new Random();

        public Besinler(int altSinir, int ustSinir)
        {
            // Besinlere random olarak atanıyor
            x1 = GetRandomNumber(altSinir, ustSinir);
            x2 = GetRandomNumber(altSinir, ustSinir);
            fx = fonksiyonDegeri(x1, x2);
            fit = fitFonksiyonu(fx);
        }

        public double fonksiyonDegeri(double x1,double x2)
        {
            // 10.Test fonksiyonu
            return (2 * Math.Pow(x1, 2)) - (1.05 * Math.Pow(x1, 4)) + (Math.Pow(x1, 6) / 6) + x1 * x2 + Math.Pow(x2, 2);
        }

        public double fitFonksiyonu(double fx)
        {
            if(fx >= 0)
            {
                return 1 / (1 + fx);
            }
            else
            {
                return 1 + Math.Abs(fx);
            }
        }

        public static void olasiklikDegerleriVer(Besinler[] besinler)
        {
            // Olasılık değerleri burada tanımlanıyor. (fit / toplam işareti fit)
            for(int i = 0; i < besinler.Length; i++)
            {
                double payda = 0;
                for(int j = 0; j < besinler.Length; j++)
                {
                    payda += besinler[i].fit;
                }
                besinler[i].olasilikDegeri = besinler[i].fit / payda;
            }
        }

        public double GetRandomNumber(double minimum, double maximum)
        {
			// Aynı random sayı gelmemesi için bir lock oluşturulmuştur.
            lock (kilitlemeNesnesi)
            {
                return rnd.NextDouble() * (maximum - minimum) + minimum;
            }
        }
    }
}