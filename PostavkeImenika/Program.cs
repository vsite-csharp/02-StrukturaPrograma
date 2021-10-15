using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vsite.CSharp.Imenici;

namespace PostavkeImenika
{ 
    class MojaKlasa1 {
        public void MojaMetoda1()
        {
            Console.WriteLine(this + ".MojaMetoda1()");
        }
    }

    class MojaKlasa2 {
        public void MojaMetoda2()
        {
            Console.WriteLine(this + ".MojaMetoda2()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            MojaKlasa1 mojaKlasa1 = new MojaKlasa1();
            MojaKlasa2 mojaKlasa2 = new MojaKlasa2();
            mojaKlasa1.MojaMetoda1();
            mojaKlasa2.MojaMetoda2();
            Console.ReadKey();

        }
    }
}
