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
            int @string = 69;
            // dodati varijablu s imenom "get". Ponoviti postupke iz prethodnog TODO.
            string get = "some";
            // Dodati varijablu s imenom "Main". Ponoviti postupke iz prethodnog TODO.
            int Main = 23; // Main nije ključna riječ
            // Dodati varijablu sa hrvatskim dijakritičkim znakovima "četrdesetšest". Ponoviti postupke iz prethodnog TODO.
            double četrdesetšest = 45;
            // Dodati istoimenu varijablu "četrdesetšest" i u njoj slovo 'š' zamijeniti njegovim Unicode kodom \u0161 i provjeriti prihvaća li prevoditelj takav oblik imena.
            //double četrdeset\u0161est = 45;
            // Dodati cjelobrojnu varijablu s imenom "бројШест" te provjeriti prihvaća li prevoditelj to ime.
            short бројШест = 6;
            // Dodati varijablu "你好" tipa string te provjeriti prihvaća li prevoditelj to ime.
            string 你好 = "你好";
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine($"Ispis: {你好}");
            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
