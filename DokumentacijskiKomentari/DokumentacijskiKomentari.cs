using System;

namespace Vsite.CSharp.StrukturaPrograma
{
    class DokumentacijskiKomentari
    {
        // 010 Postaviti strelicu (kurzor) iznad donjeg poziva metode Kvadrat i provjeriti što se prikazuje u oblačiću (eventualno napraviti build prije toga).
        static void Main(string[] args)
        {
            Console.WriteLine(Kvadrat(5));
            Console.WriteLine(DuljinaDvijeRiječi("dva", "2"));
        }

        /// <summary>
        ///   Izračunava kvadrat broja.
        /// </summary>
        /// <param name="broj">
        ///   Broj čiji kvadrat treba izračunati.
        /// </param>
        /// <returns>
        ///   Zadani broj na kvadrat, tipa <c>double</c>.
        /// </returns>
        static double Kvadrat(double broj)
        {
            return broj * broj;
        }

        // 011 Dodati dokumentacijski komentar za donju metodu i provjeriti pojavljuje li se opis u oblačiću na mjestu poziva metode u metodi Main.
        /// <summary>
        /// Izračunava ukupnu duljinu dviju riječi.
        /// </summary>
        /// <param name="prva">Prva riječ</param>
        /// <param name="druga">Druga riječ</param>
        /// <returns>Ukupan broj znakova u obje riječi.</returns>
        static int DuljinaDvijeRiječi(string prva, string druga)
        {
            return prva.Length + druga.Length;
        }
    }
}
