using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " " + "isimli musteri eklendi" );
        }
        public void MusteriListele(Musteri musteri) {

             
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " - " + musteri.TC + " -" + musteri.Bakiye+"tl");


        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " " + "isimli musteri silindi");

        }

        
    }
}
