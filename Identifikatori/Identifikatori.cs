using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.StrukturaPrograma
{
    class Identifikatori
    {
        static void Main(string[] args)
        {
            int @string = 2;
            string get = "get";
            string četrdesetšest = "s";
            string cetrdesetisest = "\u0161";
            string 你好 = "你好";
            string cirilica = "бројШест";
            int бројШест = 6;

            Console.WriteLine("GOTOVO!!!" + cetrdesetisest + 你好 + бројШест);
            Console.ReadKey(true);
        }
    }
}