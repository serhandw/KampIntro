using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Kampı";
            string kurs2 = "Temel Kurs";
            string kurs3 = "Java Kursu";

            // array - dizi

            string[] kurslar = new string[] { "Yazılım Kampı", "Java Kampı", "Pyhton Kampı", "c++ Kampı", "unıty kursu"};



            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("------2. yöntem---------");
            
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu...");


            // while döngüsü:


            int sayi = 1;

            while (true)
            {
                if (sayi==7)
                {
                    break;
                }
                Console.WriteLine(sayi);
                sayi++;
            }
            



        }
    }
}
