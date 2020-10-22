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
            MojaKlasa1 = new MojaKlasa2();
            MojaKlasa2 = new MojaKlasa1();
        }
    }
}
