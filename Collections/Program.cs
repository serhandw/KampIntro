using System;
using System.Collections.Generic;


namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] name = new string[] { "serhan", "serbay", "sergen", "aden" };
            //Console.WriteLine(name[0]);
            //Console.WriteLine(name[1]);
            //Console.WriteLine(name[2]);
            //Console.WriteLine(name[3]);


            List<string> isimler2 = new List<string> { "serhan", "serbay", "sergen", "aden" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Ali");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
