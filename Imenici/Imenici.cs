﻿using System;

namespace PrviImenik
{
    class Imenici
    {

        static void Main(string[] args)
        {
            DrugiImenik.MojaKlasa mk1 = new DrugiImenik.MojaKlasa();
            mk1.Metoda1();

            DrugiImenik.MojaKlasa mk2 = new DrugiImenik.MojaKlasa();
            mk2.Metoda2();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
