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
            if(args.Length > 0)
                Console.WriteLine(args[0]);
            Console.ReadKey();
        }

        // Zakomentirati ili preimenovati donju metodu i napraviti build projekta te ga pokrenuti.
        static void Main2()
        {
            Console.WriteLine("Krećem iz PraviMain.Main()");
        }

        public static void main()
        {
            Console.WriteLine("main()");
        }
    }
}
