using System;

namespace Vsite.CSharp.StrukturaPrograma
{
    class DokumentacijskiKomentari
    {
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

        /// <summary>
        /// Returns length of the two provided strigs
        /// </summary>
        /// <param name="prva">First string</param>
        /// <param name="druga">Second string</param>
        /// <returns>Returns length</returns>
        static int DuljinaDvijeRiječi(string prva, string druga)
        {
            return prva.Length + druga.Length;
        }
    }
}
