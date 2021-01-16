using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // do not repeat yourself - kendini tekrarlama
            // kategorietiketi burada >> değer tutucu - alias

            string kategoriEtiketi = "Kategori";
            int orenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = false; // ya da true olarak belirlenir. (doğru - yanlış)

            double dolarDun = 7.50;
            double dolarBgun = 7.40;

            if (dolarDun>dolarBgun)
            {
                Console.WriteLine("AşağıOk");
            }
            else if (dolarDun<dolarBgun)
            {
                Console.WriteLine("YukarıOk");
            }
            else
            {
                Console.WriteLine("DeğşimYok");
            }

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
          



                
            

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
