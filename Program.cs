using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int saat = DateTime.Now.Hour;

            if(saat >= 6 &&  saat <=12)
                Console.WriteLine("Günaydın!");
            else if(saat <=18)
                Console.WriteLine("İyi Günler!");
            else
                Console.WriteLine("İyi geceler!");

            string sonuc = saat <= 11 ? "StringSonuçÇalıştı":"İyiGeceler";
            int deger = saat <= 12 ? 6:8;
            Console.WriteLine(deger);

        }
    }
}
