﻿using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 69;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "serhan ayran";
            kurs2.IzlenmeOrani = 101;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "pyhton";
            kurs3.Egitmen = "aden ayran";
            kurs3.IzlenmeOrani = 100;
            

            //Console.WriteLine(kurs1.Egitmen + " " + kurs1.KursAdi);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+ " : " +kurs.Egitmen);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
        
    }
}
