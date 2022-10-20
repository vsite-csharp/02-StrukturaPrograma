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
            // TODO:040 Dodati varijablu s imenom "string". Provjeriti javlja li prevoditelj pogrešku za ime varijable. Ako javlja, napraviti potrebnu promjenu da se ime može koristiti. U protivnom ispisati vrijednost varijable.
            String @Integer;
            // TODO:041 dodati varijablu s imenom "get". Ponoviti postupke iz prethodnog TODO.
            String get = "pero";
            // TODO:042 Dodati varijablu s imenom "Main". Ponoviti postupke iz prethodnog TODO.
            double Main = 22;
            // TODO:043 Dodati varijablu sa hrvatskim dijakritičkim znakovima "četrdesetšest". Ponoviti postupke iz prethodnog TODO.
            string čačkalica = "22";
            // TODO:044 Dodati istoimenu varijablu "četrdesetšest" i u njoj slovo 'š' zamijeniti njegovim Unicode kodom \u0161 i provjeriti prihvaća li prevoditelj takav oblik imena.
            string četrdesetšest = "";
            //string četrdeset\u0161est; ne prolazi
            // TODO:045 Dodati cjelobrojnu varijablu s imenom "бројШест" te provjeriti prihvaća li prevoditelj to ime.
            int бројШест = 33;
            // TODO:046 Dodati varijablu "你好" tipa string te provjeriti prihvaća li prevoditelj to ime.
            string 你好 = "NiHao -> Dobar dan";

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
