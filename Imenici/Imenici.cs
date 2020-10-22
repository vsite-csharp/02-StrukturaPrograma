using System;

namespace Vsite.CSharp.PrviImenik
{
    class Imenici
    {

        static void Main(string[] args)
        {
            PrviImenik.MojaKlasa mk1 = new PrviImenik.MojaKlasa();
            mk1.Metoda1();

          DrugiImenik.MojaKlasa mk2 = new DrugiImenik.MojaKlasa();
            mk2.Metoda2();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }

    }
}
