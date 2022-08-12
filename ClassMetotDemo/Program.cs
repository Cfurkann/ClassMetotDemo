using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Alp";
            musteri1.SoyAd = "Tekin";
            musteri1.HesapNo = 111111111;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Kaan";
            musteri2.SoyAd = "Topuz";
            musteri2.HesapNo = 111111111;

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2};

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id:  " + musteri.Id);
                Console.WriteLine("Müşteri Adı-Soyadı: " + musteri.Ad+"  "+musteri.SoyAd );
                Console.WriteLine("Müşteri Hesap Numarası :" + musteri.HesapNo );
                Console.WriteLine("********************************************************");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            Console.WriteLine("--------------------------------------");
            musteriManager.MusteriGuncelle(musteri1);
            Console.WriteLine("--------------------------------------");
            musteriManager.MusteriListele(musteri1);
            Console.WriteLine("--------------------------------------");
            musteriManager.MusteriSil(musteri1);
            Console.WriteLine("--------------------------------------");
            musteriManager.MusteriEkle2(3,"Selin","Kara",22222222);
        }
    }
}
