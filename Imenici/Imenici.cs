using System;

namespace PrviImenik
{
    class Imenici
    {

        static void Main(string[] args)
        {
            MojaKlasa mk1 = new MojaKlasa();
            mk1.Metoda1();

            MojaKlasa mk2 = new MojaKlasa();
            mk2.Metoda2();

            DrugiImenik.MojaKlasa mk_1 = new DrugiImenik.MojaKlasa();
            mk_1.Metoda2();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
