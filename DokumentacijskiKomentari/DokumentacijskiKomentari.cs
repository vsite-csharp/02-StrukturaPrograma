using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.StrukturaPrograma
{
    class DokumentacijskiKomentari
    {
        /// <summary>
        /// Primjer dokumentacijskih komentara 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine(Kvadrat(5));
            Console.WriteLine(DuljinaDvijeRiječi("dva", "2"));
            Console.WriteLine(Math.Sqrt(2.0));
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
        /// Izračunava ukupnu duljinnu dvije riječi.
        /// </summary>
        /// <param name="prva">Prva riječ.</param>
        /// <param name="druga">Druga riječ.</param>
        /// <returns>Cijeli broj jednak ukupnoj duljini riječi.</returns>
        static int DuljinaDvijeRiječi(string prva, string druga)
        {
            return (prva + druga).Length;
        }
    }
}
