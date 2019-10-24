using System;

namespace PrviImenik
{
    class Imenici
    {

        // TODO:020 Pokrenuti program i provjeriti ispise poziva donjih metoda.
        static void Main(string[] args)
        {
            MojaKlasa mk1 = new MojaKlasa();
            mk1.Metoda1();

            // TODO:021 Promijeniti donji poziv tako da se poziva klasa MojaKlasa iz imenika DrugiImenik. Napraviti build, pokrenuti program i provjeriti ispise.
           DrugiImenik.MojaKlasa mk2 = new DrugiImenik.MojaKlasa();
            mk2.Metoda2();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
