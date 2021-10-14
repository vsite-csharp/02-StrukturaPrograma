using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Imenici
{
    class Program
    {
        static void Main(string[] args)
        {
            MojaKlasa1 mk1 = new MojaKlasa1();
            MojaKlasa2 mk2 = new MojaKlasa2();
        }

        
    }

    class MojaKlasa1
    {
        public void Metoda1()
        {
            Console.WriteLine(this + ".Metoda2()");
        }
    }
    class MojaKlasa2
    {
        public void Metoda2()
        {
            Console.WriteLine(this + ".Metoda2()");
        }
    }
}
