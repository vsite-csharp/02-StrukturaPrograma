using System;

// TODO:000 Napraviti build projekta i pogledati koju pogrešku prevoditelj javlja. Usporediti metode Main u klasama PraviMain i JošJedanMain.


namespace Vsite.CSharp.StrukturaPrograma
{
    class PraviMain
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Krećem iz PraviMain.Main(string[] args)");
        }

        // TODO:002 Zakomentirati ili preimenovati donju metodu i napraviti build projekta te ga pokrenuti.
        //static void Main()
        //{
        //    Console.WriteLine("Krećem iz PraviMain.Main()");
        //}

        public static void main()
        {
            Console.WriteLine("main()");
        }
    }
}
