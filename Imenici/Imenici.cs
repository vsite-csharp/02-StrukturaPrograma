using System;

namespace Vsite.CSharp.PrviImenik
{
    class Imenici
    {

        // 020 Pokrenuti program i provjeriti ispise poziva donjih metoda.
        static void Main(string[] args)
        {
            MojaKlasa mk1 = new MojaKlasa();
            mk1.Metoda1();

            // 021 Promijeniti donji poziv tako da se poziva klasa MojaKlasa iz imenika Vsite.CSharp.DrugiImenik. Napraviti build, pokrenuti program i provjeriti ispise.
            Vsite.CSharp.DrugiImenik.MojaKlasa mk2 = new Vsite.CSharp.DrugiImenik.MojaKlasa();
            mk2.Metoda2();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }

        // 030 U kazalu "03 Promjena postavki imenika" kreirati projekt za konzolnu aplikaciju s imenom PostavkeImenika.
        // 031 U postavkama projekta promijeniti podrazumijevani imenik u Vsite.CSharp.Imenici te ispraviti imenik u automatski generiranom kodu
        // TODO:032 Definirati dvije nove klase: MojaKlasa1 i MojaKlasa2 te instancirati objekte tih klasa u metodi Program.Main - ovo jos nisam napravila
    }
}
