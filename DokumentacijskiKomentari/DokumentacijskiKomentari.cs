using System;

namespace Vsite.CSharp.StrukturaPrograma
{
    /// <summary>
    /// dokumentacijki komentari
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
      /// Metoda zbraja duljinu prve i druge riječi
      /// </summary>
      /// <param name="prva">prva riječ</param>
      /// <param name="druga">druga riječ</param>
      /// <returns>broj znakova u obje rijeci </returns>
        static int DuljinaDvijeRiječi(string prva, string druga)
        {
            return prva.Length + druga.Length;
        }
    }
}
