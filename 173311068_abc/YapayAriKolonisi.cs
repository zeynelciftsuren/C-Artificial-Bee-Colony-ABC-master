using System;
using System.Collections.Generic;

namespace _173311068_abc
{
    class YapayAriKolonisi
    {
        int koloniBoyutu;
        int altSinir;
        int ustSinir;
        int cevrimSayisi;
        int yemekKaynak;
        int denemeSayisi;

        int isciAri;
        int gozcuAri;

        public Besin besin;

        public double eniyiX1;
        public double eniyiX2;

        // Fx değerleri bu listede tutuluyor
        public List<double> fxDegerleri = new List<double>();

        // Fit değerleri bu listede tutuluyor
        public List<double> fitDegerleri = new List<double>();

        // En iyi X1 ve X2 değerleri bu listede tutuluyor
        public List<double> eniyiX1List = new List<double>();
        public List<double> eniyiX2List = new List<double>();

        // Random sayi üretimi için bir kilitleme nesnesi yaptım
        public static readonly Object kilitlemeNesnesi = new Object();
        public static readonly Random rnd = new Random();


        // int iyilestirilememe = 0; // İyileştirilmediğinde artırılacaktır


        public YapayAriKolonisi(int koloniBoyutu, int altSinir, int ustSinir,int cevrimSayisi,int denemeSayisi)
        {
            this.koloniBoyutu = koloniBoyutu;

            // Koloninin boyutunun yarısı yemek kaynağına eşittir.
            this.yemekKaynak = koloniBoyutu / 2;
            this.isciAri = koloniBoyutu / 2; // Koloni boyutumuz ne olursa yarısı işçi arı olacak
            this.gozcuAri = koloniBoyutu / 2; // Diğer yarısı gözcü arı olacaktır
            
            this.altSinir = altSinir;
            this.ustSinir = ustSinir;
            this.cevrimSayisi = cevrimSayisi;
            this.denemeSayisi = denemeSayisi;

            besin = new Besin(yemekKaynak,altSinir,ustSinir);

            // Besinler Oluşturuluyor
            besin.besinOlustur();

            for(int i = 0; i < cevrimSayisi; i++)
            {
                // İşçi Arı Fazı
                isciAriFazi();

                // Her işçi arı için olasılık değerleri tanımlama
                isciAriOlasiliklariTanimla();

                // Gözcü Arı Safhası
                gozcuAriFazi();

                //Eğer verilen deneme sayısı iyileştirilememe sayısını geçti ise onu yeni değerlerle tekrardan oluşturuluyor
                for(int j = 0; j < yemekKaynak; j++)
                {
                    if(besin.Besinler[j].iyilestirilememe > denemeSayisi)
                    {
                        besin.Besinler[j] = new Besinler(altSinir, ustSinir);
                    }
                }

                // En iyi yemek bize geri döndürülüyor
                eniyiYemek();
            }

        }

        void isciAriFazi()
        {
            for(int i = 0; i < yemekKaynak; i++)
            {
                // K değeri rastgele seçilmiş komşu
                int k = (int)GetRandomNumber(0, yemekKaynak);
                // 0. parametere mi 1. parametre mi alınacak
                int j = (int)GetRandomNumber(0, 2);
                // -1 ile 1 aralığında rastgele 
                double fi = GetRandomNumber(-1, 1);

                double x = 0;
                double xDiger = 0;

                // x i,j
                if (j == 0)
                {
                    x = besin.Besinler[i].x1;
                }
                else
                {
                    x = besin.Besinler[i].x2;
                }

                // (x 0,0 - x 1,0 --- x k,j)
                if (j == 0)
                {
                    xDiger = besin.Besinler[k].x1;
                }
                else
                {
                    xDiger = besin.Besinler[k].x2;
                }

                double sonuc = 0;


                double yeniSonucX = x + fi;
                yeniSonucX = fitFonksiyonu(yeniSonucX);

                double yeniSonucX2 = x - xDiger;
                yeniSonucX2 = fitFonksiyonu(yeniSonucX2);

                sonuc = fitFonksiyonu(amacFonksiyonu(yeniSonucX, yeniSonucX2));

                if(sonuc > ustSinir)
                {
                    sonuc = ustSinir;
                }
                else if(sonuc < altSinir)
                {
                    sonuc = altSinir;
                }

                if (sonuc < besin.Besinler[i].fit)
                {
                    // Eğer geliştirilemediyse sayaç arttırılır
                    besin.Besinler[i].iyilestirilememe += 1;
                }
                else{
                    // Eğer geliştirilirdi ise yerine yazılır 
                    besin.Besinler[k].x1 = yeniSonucX;
                    besin.Besinler[k].x2 = yeniSonucX2;
                    besin.Besinler[k].fx = amacFonksiyonu(yeniSonucX, yeniSonucX2);
                    besin.Besinler[k].fit = sonuc;
                }
            }
        }

        public void gozcuAriFazi()
        {
            Random rnd = new Random();
            double randomDeger = 0;
            lock (kilitlemeNesnesi)
            {
                randomDeger = rnd.Next();
            }
            for (int i = 0; i < yemekKaynak; i++)
            {
                if(besin.Besinler[i].olasilikDegeri > randomDeger)
                {
                    gozcuAriHesapla(i);
                }
            }
        }

        public void gozcuAriHesapla(int i)
        {
            // Gözcü arı için hesaplamalar 

            Random rnd = new Random();

            // K değeri rastgele seçilmiş komşu
            int k = (int)GetRandomNumber(0, yemekKaynak);
            // 0. parametere mi 1. parametre mi alınacak
            int j = (int)GetRandomNumber(0, 2);
            // -1 ile 1 aralığında rastgele 
            double fi = (int)GetRandomNumber(-1, 1);

            double x = 0;
            double xDiger = 0;

            // x i,j
            if (j == 0)
            {
                x = besin.Besinler[i].x1;
            }
            else
            {
                x = besin.Besinler[i].x2;
            }

            // (x 0,0 - x 1,0 --- x k,j)
            if (j == 0)
            {
                xDiger = besin.Besinler[k].x1;
            }
            else
            {
                xDiger = besin.Besinler[k].x2;
            }

            double sonuc = 0;


            double yeniSonucX = x + fi;
            yeniSonucX = fitFonksiyonu(yeniSonucX);

            double yeniSonucX2 = x - xDiger;
            yeniSonucX2 = fitFonksiyonu(yeniSonucX2);

            sonuc = fitFonksiyonu(amacFonksiyonu(yeniSonucX, yeniSonucX2));

            if (sonuc > ustSinir)
            {
                sonuc = ustSinir;
            }
            else if (sonuc < altSinir)
            {
                sonuc = altSinir;
            }
            

            if (sonuc < besin.Besinler[i].fit)
            {
                // Eğer geliştirilemediyse sayaç arttırılır
                besin.Besinler[i].iyilestirilememe += 1;
            }
            else
            {
                // Eğer geliştirilirdi ise yerine yazılır 
                besin.Besinler[k].x1 = yeniSonucX;
                besin.Besinler[k].x2 = yeniSonucX2;
                besin.Besinler[k].fx = amacFonksiyonu(yeniSonucX, yeniSonucX2);
                besin.Besinler[k].fit = sonuc;
            }

        }

        public void isciAriOlasiliklariTanimla()
        {
            besin.isciAriOlasilik();
        }

        public double  amacFonksiyonu(double x,double y)
        {
            return ( 2 * Math.Pow(x, 2) ) - ( 1.05 * Math.Pow(x,4) ) + (Math.Pow(x,6) / 6) + x * y  + Math.Pow(y,2);
        }

        public double fitFonksiyonu(double fi)
        {
            if( fi >= 0)
            {
                return 1 / (1 + fi); 
            }
            else
            {
                return 1 + Math.Abs(fi);
            }
        }

        public double fitDegerleriToplam()
        {
            // Besinler içindeki bütün fit değerlerini toplar
            double toplam = 0;
            for (int i = 0; i < besin.Besinler.Length; i++)
            {
                toplam += besin.Besinler[i].fit;
            }
            return toplam;
        }

        public void eniyiYemek()
        {
            // Besinlerin arasından en kalitesini alır
            Besinler enKaliteli = besin.enKaliteliYemek();
            eniyiX1 = enKaliteli.x1;
            eniyiX2 = enKaliteli.x2;
            eniyiX1List.Add(eniyiX1);
            eniyiX2List.Add(eniyiX2);
            fxDegerleri.Add(enKaliteli.fx);
            fitDegerleri.Add(enKaliteli.fit);
        }

        public double GetRandomNumber(double minimum, double maximum)
        {
            // Aynı sayı üretilmemesi lock kullanılmıştır.
            lock (kilitlemeNesnesi)
            {
                return rnd.NextDouble() * (maximum - minimum) + minimum;
            }
        }
    }
}