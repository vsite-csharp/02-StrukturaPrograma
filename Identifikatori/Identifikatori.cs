﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.StrukturaPrograma
{
    class Identifikatori
    {
        static void Main(string[] args)
        {
            // OK-TODO:040 Dodati varijablu s imenom "string". Provjeriti javlja li prevoditelj pogrešku za ime varijable. Ako javlja, napraviti potrebnu promjenu da se ime može koristiti. U protivnom ispisati vrijednost varijable.
            int @string = 5;

            // OK-TODO:041 dodati varijablu s imenom "get". Ponoviti postupke iz prethodnog TODO.
            string get = "mojaVarijabla"; /*get nije ključna riječ?*/

            // OK-TODO:042 Dodati varijablu s imenom "Main". Ponoviti postupke iz prethodnog TODO.
            string main = "mojMain";

            // OK-TODO:043 Dodati varijablu sa hrvatskim dijakritičkim znakovima "četrdesetšest". Ponoviti postupke iz prethodnog TODO.
            double četrdeseptet = 35.2;

            // OK-TODO:044 Dodati istoimenu varijablu "četrdesetšest" i u njoj slovo 'š' zamijeniti njegovim Unicode kodom \u0161 i provjeriti prihvaća li prevoditelj takav oblik imena.
            double četrdeset\u0161est = 35.2;

            // OK-TODO:045 Dodati cjelobrojnu varijablu s imenom "бројШест" te provjeriti prihvaća li prevoditelj to ime.
            short бројШест = 1;

            // OK-TODO:046 Dodati varijablu "你好" tipa string te provjeriti prihvaća li prevoditelj to ime.
            //string 你好 = "njiHao";
            string 你好 = "你好";

            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine(你好);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
