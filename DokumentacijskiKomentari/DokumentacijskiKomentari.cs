﻿using System;
/// <summary>
/// Klasa dokumentacijskih komentara
/// </summary>
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
        ///   Izračunava kvadrat broja bla bla
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

        // TODO:011 Dodati dokumentacijski komentar za donju metodu i provjeriti pojavljuje li se opis u oblačiću na mjestu poziva metode u metodi Main.
        /// <summary>
        /// Izračunava ukupnu dujinu dviju riječi
        /// </summary>
        /// <param name="prva">Prva rijec</param>
        /// <param name="druga">Druga rijec</param>
        /// <returns>Ukupan broj znakova u dvije rijeci</returns>
        static int DuljinaDvijeRiječi(string prva, string druga)
        {
            return prva.Length + druga.Length;
        }
    }
}
