using System;
using System.Collections.Generic;
using System.Text;

namespace BankaMusteri
{
    class MusteriManager
    {
        public void MusteriEKle(Musteri m)
        {




            Console.WriteLine("Yeni Banka Müşterisi Eklendi : " + " : " + m.Id + m.Ad + " : " + m.SoyAd + " : " + m.DogumTarihi + " :" + m.DogumYeri + " : " + m.Cinsiyet + " : ");

            Console.WriteLine("---------------");
        }

        public void MusteriListele(Musteri [] musteriler)
        {
            

            foreach (var m in musteriler)
            {

                Console.WriteLine(m.Id + ":" + m.Ad + ": " + m.SoyAd + ": "+ m.DogumTarihi + ": " + m.DogumYeri+ ":" + m.Cinsiyet + " :"  );


                Console.WriteLine(".............");
            }





        }

        public void MusteriSil(Musteri [] m)
        {
            for (int i = 0; i < m.Length; i++)
            {
                Console.WriteLine("Bankanın" + i + "Müşterisi Silindi " + m[i]);
                Array.Clear(m, 2, 3);
            }
            Console.ReadLine();
        }

    }
}
