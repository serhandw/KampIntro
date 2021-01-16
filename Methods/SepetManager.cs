using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class SepetManager
    {
        public void Ekle(Product urun)
        {
            Console.WriteLine("Tebrikler.. Sepete Eklendi: " + urun.Adi);
        }

        public void Ekle2(Product urun )
        {
            Console.WriteLine("Tebrikler.. Sepete Eklendi: "+urun.Adi );
        }
    }
}
