using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "İsmail";
            musteri1.Soyadi = "GENAR";
            musteri1.TC = "11111111111";
            musteri1.Bakiye = 200;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ayşe";
            musteri2.Soyadi = "GENAR";
            musteri2.TC = "11111111112";
            musteri2.Bakiye = 2000;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Fatmanur";
            musteri3.Soyadi = "GENAR";
            musteri3.TC = "11111111113";
            musteri3.Bakiye = 0;

            Musteri musteri4 = new Musteri();
            musteri4.Adi = "İAybüke";
            musteri4.Soyadi = "GENAR";
            musteri4.TC = "11111111114";
            musteri4.Bakiye = 100;

            Musteri musteri5 = new Musteri();
            musteri5.Adi = "Şeyma";
            musteri5.Soyadi = "GENAR";
            musteri5.TC = "11111111115";
            musteri5.Bakiye = 20;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("yeni müşteri");
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            
            Console.WriteLine("*******************************************************************");

            Console.WriteLine("silinen müşteri");

            musteriManager.MusteriSil(musteri1);
           
            musteriManager.MusteriSil(musteri5);
            Console.WriteLine("*******************************************************************");

            Console.WriteLine("mevcut müşteriler");

            foreach (Musteri musteris in musteriler)
            {
                musteriManager.MusteriListele(musteris);
            }

           



        }
    }
}
