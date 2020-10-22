using System;

// TODO:000 Napraviti build projekta i pogledati koju pogrešku prevoditelj javlja. Usporediti metode Main u klasama PraviMain i JošJedanMain.

// TODO:001 U postavkama projekta staviti da je klasa PraviMain ulazna (Startup object) te pokrenuti novi build.

namespace Vsite.CSharp.StrukturaPrograma
{
    class PraviMain
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Krećem iz PraviMain.Main(string[] args)");
        }

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
