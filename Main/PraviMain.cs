using System;

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
