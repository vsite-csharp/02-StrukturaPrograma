namespace Vsite.CSharp.StrukturaPrograma
{
    static class Identifikatori
    {
        static void Main(string[] args)
        {
            // :040 Dodati varijablu s imenom "string". Provjeriti javlja li prevoditelj pogrešku za ime varijable. Ako javlja, napraviti potrebnu promjenu da se ime može koristiti. U protivnom ispisati vrijednost varijable.
            int @string= 5;

            // :041 dodati varijablu s imenom "get". Ponoviti postupke iz prethodnog TODO.
            string get = "Pero";
            // :042 Dodati varijablu s imenom "Main". Ponoviti postupke iz prethodnog TODO.
            double Main = 3.14;
            // :043 Dodati varijablu sa hrvatskim dijakritičkim znakovima "četrdesetšest". Ponoviti postupke iz prethodnog TODO.
            int četrdesetšest = 46;
            // :044 Dodati istoimenu varijablu "četrdesetšest" i u njoj slovo 'š' zamijeniti njegovim Unicode kodom \u0161 i provjeriti prihvaća li prevoditelj takav oblik imena.
            // int četrdeset\u0161est = 46;
            // :045 Dodati cjelobrojnu varijablu s imenom "бројШест" te provjeriti prihvaća li prevoditelj to ime.
            double бројШест = 6;
            // :046 Dodati varijablu "你好" tipa string te provjeriti prihvaća li prevoditelj to ime.
            string 你好 = "你好";
            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
