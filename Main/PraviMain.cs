using System;

// Napraviti build projekta i pogledati koju pogrešku prevoditelj javlja. Usporediti metode Main u klasama PraviMain i JošJedanMain.

// U postavkama projekta staviti da je klasa PraviMain ulazna (Startup object) te pokrenuti novi build.

namespace Vsite.CSharp.StrukturaPrograma
{
    class PraviMain
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Krećem iz PraviMain.Main(string[] args)");
            Console.Write(args[0]);
            Console.Write(" " + args[1] + "!");
            Console.ReadKey(false); //Ne prikazuje tipku
        }

        // Zakomentirati ili preimenovati donju metodu i napraviti build projekta te ga pokrenuti.
        static void Mainara()
        {
            Console.WriteLine("Krećem iz PraviMain.Main()");
        }

        public static void main()
        {
            Console.WriteLine("main()");
        }
    }
}
