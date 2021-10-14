using System;

// 000 Napraviti build projekta i pogledati koju pogrešku prevoditelj javlja. Usporediti metode Main u klasama PraviMain i JošJedanMain.

// 001 U postavkama projekta staviti da je klasa PraviMain ulazna (Startup object) te pokrenuti novi build.

namespace Vsite.CSharp.StrukturaPrograma
{
    class PraviMain
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Krećem iz PraviMain.Main(string[] args)");
            Console.WriteLine(args[0]);
            Console.ReadKey(false);
        }

        // 002 Zakomentirati ili preimenovati donju metodu i napraviti build projekta te ga pokrenuti.
        //static void Main() // podrazumjeva se da je private
        //{
        //    Console.WriteLine("Krećem iz PraviMain.Main()");
        //}

        public static void main() //Nju ompajler zanemari za main metodu
        {
            Console.WriteLine("main()");
        }
    }
}
