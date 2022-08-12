using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + "  isimli müşteri eklenecek");
            Console.WriteLine("Müşteri ekleniyor");
            Console.WriteLine("Müşteri eklendi");
        }

        public void MusteriEkle2(int Id,string Ad,string Soyad,int HesapNo)
        {
            Console.WriteLine(Ad + "  isimli müşteri eklenecek");
            Console.WriteLine("Müşteri ekleniyor");
            Console.WriteLine("Müşteri eklendi");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + "  isimli müşteri silinecek");
            Console.WriteLine("Müşteri siliniyor");
            Console.WriteLine("Müşteri silindi");
        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Müşteri listeleniyor");
            Console.WriteLine(musteri.Ad +" "+musteri.SoyAd);
        }

        public void MusteriGuncelle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad +"  isimli müşteri güncellenecek" );
            Console.WriteLine("Müşteri güncelleniyor");
            Console.WriteLine("Müşteri güncellendi");
        }
    }
}
