using System;



namespace Vsite.CSharp.StrukturaPrograma

    /// Primjer iz dokumentacijskih komentara
{
    class PraviMain
    {
        private static void MyMain(string[] args)
        {
            Console.WriteLine("Krećem iz PraviMain.Main(string[] args)");
        }

        // TODO:002 Zakomentirati ili preimenovati donju metodu i napraviti build projekta te ga pokrenuti.
        static void MyMain()
        {
            Console.WriteLine("Krećem iz PraviMain.Main()");
        }

        public static void main()
        {
            Console.WriteLine("main()");
        }
    }
}
