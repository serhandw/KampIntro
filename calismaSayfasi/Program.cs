using System;

namespace calismaSayfasi
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] kurslar = new string[] { "Yazılım Kampı", "Java Kampı", "Pyhton Kampı", "c++ Kampı", "unıty kursu"; "serhan" };



            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

        }
    }
}
