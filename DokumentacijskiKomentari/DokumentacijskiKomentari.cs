﻿using System;

namespace Vsite.CSharp.StrukturaPrograma
{
    /// <summary>
    /// primjer dokumentacijskih komentara
    /// </summary>
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
        /// Izračunava ukupnu duljinu dvije riječi
        /// </summary>
        /// <param name="prva">prva rijec</param>
        /// <param name="druga">druga rijec</param>
        /// <returns></returns>
        static int DuljinaDvijeRiječi(string prva, string druga)
        {
            return prva.Length + druga.Length;
        }
    }
}
