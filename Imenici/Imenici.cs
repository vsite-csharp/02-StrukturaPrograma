﻿using System;

namespace Vsite.CSharp.PrviImenik
{
    class Imenici
    {

        static void Main(string[] args)
        {
            MojaKlasa mk1 = new MojaKlasa();
            mk1.Metoda1();

            //Promijeniti donji poziv tako da se poziva klasa MojaKlasa iz imenika Vsite.CSharp.DrugiImenik. Napraviti build, pokrenuti program i provjeriti ispise.
            DrugiImenik.MojaKlasa mk2 = new DrugiImenik.MojaKlasa();
            mk2.Metoda2();


            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }

    }
}
