using System;

namespace Vsite.CSharp.PrviImenik
{
    class Imenici
    {

        // TODO:020 Pokrenuti program i provjeriti ispise poziva donjih metoda.
        static void Main(string[] args)
        {
            MojaKlasa mk1 = new MojaKlasa();
            mk1.Metoda1();

            // TODO:021 Promijeniti donji poziv tako da se poziva klasa MojaKlasa iz imenika Vsite.CSharp.DrugiImenik. Napraviti build, pokrenuti program i provjeriti ispise.
            MojaKlasa mk2 = new MojaKlasa();
            mk2.Metoda2();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }

        // OK-TODO:030 U kazalu "03 Promjena postavki imenika" kreirati projekt za konzolnu aplikaciju s imenom PostavkeImenika.
        // OK-TODO:031 U postavkama projekta promijeniti podrazumijevani imenik u Vsite.CSharp.Imenici te ispraviti imenik u automatski generiranom kodu
        // kTODO:032 Definirati dvije nove klase: MojaKlasa1 i MojaKlasa2 te instancirati objekte tih klasa u metodi Program.Main
    }
}
