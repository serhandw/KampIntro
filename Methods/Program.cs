using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Product urun1 = new Product();

            urun1.Id = 001;
            urun1.Adi = "Mandarin";
            urun1.Fiyati = 1.75;
            urun1.Açiklama = "Satsumas";

            Product urun2 = new Product();
            urun2.Id = 002;
            urun2.Adi = "Orange";
            urun2.Fiyati = 2.55;
            urun2.Açiklama = "Valencia";

            Product urun3 = new Product();
            urun3.Id = 003;
            urun3.Adi = "Lemon";
            urun3.Fiyati = 3.00;
            urun3.Açiklama = "Lamas";
         

            Product[] urunler = new Product[] {urun1, urun2, urun3};

            foreach (Product urun in urunler) 
            {
                Console.WriteLine("00"+urun.Id+" "+urun.Adi + " "+urun.Fiyati+" "+urun.Açiklama);
            }

            Console.WriteLine("------------------Metodlar-------------------");

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun3);
            sepetManager.Ekle(urun1);
            sepetManager.Ekle2(urun3);
            




        }
    }
}




//dont repeat yourself *DRY* / kendini tekrar etme.. *serhandw*




