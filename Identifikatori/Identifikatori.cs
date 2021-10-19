using System;

namespace Vsite.CSharp.StrukturaPrograma
{
    class Identifikatori
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start with TODO tests");
            Console.ReadKey(true);
            // TODO:040 Dodati varijablu s imenom "string". Provjeriti javlja li prevoditelj pogrešku za ime varijable. Ako javlja, napraviti potrebnu promjenu da se ime može koristiti. U protivnom ispisati vrijednost varijable.
            //int string = 50;
            //Console.WriteLine(string);
            // DONE: javlja grešku "Cannot implicitly convert type 'int' to 'string'"

            // TODO:041 dodati varijablu s imenom "get". Ponoviti postupke iz prethodnog TODO.
            long get = 79;
            Console.WriteLine(get);
            Console.WriteLine("DONE");
            // DONE

            // TODO:042 Dodati varijablu s imenom "Main". Ponoviti postupke iz prethodnog TODO.
            string Main = "Ime Main";
            Console.WriteLine(Main);
            Console.WriteLine("DONE");
            // DONE

            // TODO:043 Dodati varijablu sa hrvatskim dijakritičkim znakovima "četrdesetšest". Ponoviti postupke iz prethodnog TODO.
            string četrdesetšest = "četrdesetšest";
            Console.WriteLine(četrdesetšest);
            Console.WriteLine("DONE");
            // DONE

            // TODO:044 Dodati istoimenu varijablu "četrdesetšest" i u njoj slovo 'š' zamijeniti njegovim Unicode kodom \u0161 i provjeriti prihvaća li prevoditelj takav oblik imena.
            //string četrdeset\u0161est = "četrdesetšest";
            //Console.WriteLine(četrdeset\u0161est);
            //Console.WriteLine("DONE");
            // DONE: The variable četrdesetšest is already defined

            // TODO:045 Dodati cjelobrojnu varijablu s imenom "бројШест" te provjeriti prihvaća li prevoditelj to ime.
            short бројШест = 50;
            Console.WriteLine(бројШест);
            Console.WriteLine("DONE");
            // DONE

            // TODO:046 Dodati varijablu "你好" tipa string te provjeriti prihvaća li prevoditelj to ime.
            string 你好 = "ab";
            Console.WriteLine(你好);
            Console.WriteLine("DONE");
            Console.WriteLine("Tests are finished. Press any key to close the program");
            Console.ReadKey(true);
            // DONE
        }
    }
}
