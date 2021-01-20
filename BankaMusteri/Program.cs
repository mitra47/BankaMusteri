using System;

namespace BankaMusteri
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Musteri m = new Musteri();

            m.Id = 001;
            m.Ad = "İsmail";
            m.SoyAd = "Ekin";
            m.DogumTarihi =1989 ;
            m.DogumYeri = "Mersin";
            m.Cinsiyet = "Erkek";

            Console.WriteLine(m.Id);
            Console.WriteLine(m.Ad);
            Console.WriteLine(m.SoyAd);
            Console.WriteLine(m.DogumTarihi);
            Console.WriteLine(m.DogumYeri);
            Console.WriteLine(m.Cinsiyet);
            Console.WriteLine("------------");




        }
    }
}
