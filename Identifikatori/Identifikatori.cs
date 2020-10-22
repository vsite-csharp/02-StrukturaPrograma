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
            // ++TODO:040 Dodati varijablu s imenom "string". Provjeriti javlja li prevoditelj pogrešku za ime varijable. Ako javlja, napraviti potrebnu promjenu da se ime može koristiti. U protivnom ispisati vrijednost varijable.

            int @string = 5;

            // ++TODO:041 dodati varijablu s imenom "get". Ponoviti postupke iz prethodnog TODO.

            string get = "get";

            // ++TODO:042 Dodati varijablu s imenom "Main". Ponoviti postupke iz prethodnog TODO.

            double Main = 3.12;

            // ++TODO:043 Dodati varijablu sa hrvatskim dijakritičkim znakovima "četrdesetšest". Ponoviti postupke iz prethodnog TODO.

            int četrdesetšest = 46;

            // ++TODO:044 Dodati istoimenu varijablu "četrdesetšest" i u njoj slovo 'š' zamijeniti njegovim Unicode kodom \u0161 i provjeriti prihvaća li prevoditelj takav oblik imena.

            /*
             * int četrdeset\u0161est = 46;
             */

            // ++TODO:045 Dodati cjelobrojnu varijablu s imenom "бројШест" te provjeriti prihvaća li prevoditelj to ime.

            int бројШест = 6;

            // ++TODO:046 Dodati varijablu "你好" tipa string te provjeriti prihvaća li prevoditelj to ime.

            string 你好 = "你好";

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
