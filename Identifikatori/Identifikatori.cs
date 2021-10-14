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
            
            int @string = 5;
            
            string get = "some";
            
            int Main = 23;
            // TODO:043 Dodati varijablu sa hrvatskim dijakritičkim znakovima "četrdesetšest". Ponoviti postupke iz prethodnog TODO.
            double četrdesetšest = 45;
            //044 Dodati istoimenu varijablu "četrdesetšest" i u njoj slovo 'š' zamijeniti njegovim Unicode kodom \u0161 i provjeriti prihvaća li prevoditelj takav oblik imena.
            // 045 Dodati cjelobrojnu varijablu s imenom "бројШест" te provjeriti prihvaća li prevoditelj to ime.
            short бројШест = 6;
            // 46 Dodati varijablu "你好" tipa string te provjeriti prihvaća li prevoditelj to ime.
            short 你好 = 5;
            Console.WriteLine("你好");
            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
