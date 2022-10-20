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
            // Dodati varijablu s imenom "string". Provjeriti javlja li prevoditelj pogrešku za ime varijable. Ako javlja, napraviti potrebnu promjenu da se ime može koristiti. U protivnom ispisati vrijednost varijable.
            int @string = 5;
            // dodati varijablu s imenom "get". Ponoviti postupke iz prethodnog TODO.
            string get = "Pero";
            // Dodati varijablu s imenom "Main". Ponoviti postupke iz prethodnog TODO.
            double Main = 10.2;
            // Dodati varijablu sa hrvatskim dijakritičkim znakovima "četrdesetšest". Ponoviti postupke iz prethodnog TODO.
            string četrdesetšest = "četrdesetšest";
            // Dodati istoimenu varijablu "četrdesetšest" i u njoj slovo 'š' zamijeniti njegovim Unicode kodom \u0161 i provjeriti prihvaća li prevoditelj takav oblik imena.
            string četrdesetu0161est = "četrdeset\u0161est";
            // Dodati cjelobrojnu varijablu s imenom "бројШест" te provjeriti prihvaća li prevoditelj to ime.
            int бројШест = 10;
            // Dodati varijablu "你好" tipa string te provjeriti prihvaća li prevoditelj to ime.
            string 你好 = "Dobar dan";
            string dobar_dan = "你好";

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
