namespace Vsite.CSharp.StrukturaPrograma
{
    static class Identifikatori
    {
        static void Main(string[] args)
        {
            // ODO:040 Dodati varijablu s imenom "string". Provjeriti javlja li prevoditelj pogrešku za ime varijable. Ako javlja, napraviti potrebnu promjenu da se ime može koristiti. U protivnom ispisati vrijednost varijable.
            int @string = 5;
            // ODO:041 dodati varijablu s imenom "get". Ponoviti postupke iz prethodnog TODO.
            string get = "Ja!!";
            // ODO:042 Dodati varijablu s imenom "Main". Ponoviti postupke iz prethodnog TODO.
            double Main = 3.14;
            // ODO:043 Dodati varijablu sa hrvatskim dijakritičkim znakovima "četrdesetšest". Ponoviti postupke iz prethodnog TODO.
            int četrdesetsšest = 47;
            // ODO:044 Dodati istoimenu varijablu "četrdesetšest" i u njoj slovo 'š' zamijeniti njegovim Unicode kodom \u0161 i provjeriti prihvaća li prevoditelj takav oblik imena.
            int četrdeset\u0161est = 47;
            // ODO:045 Dodati cjelobrojnu varijablu s imenom "бројШест" te provjeriti prihvaća li prevoditelj to ime.
            double бројШест = 6;
            // ODO:046 Dodati varijablu "你好" tipa string te provjeriti prihvaća li prevoditelj to ime.
            string 你好 = "Nihao";
            string nihao = "你好";
            Console.WriteLine("GOTOVO!!!");
            Console.WriteLine(nihao);
            Console.ReadKey(true);
        }
    }
}
