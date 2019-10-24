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
           
            int @string=10;

            
            string get="get";
            //get je konteksna ključna riječ...nije ključna riječ

            
            double Main = 3.14;
            //i ovo prolazi

            
            int četrdesetšest = 47;            //mogu se koristiti dijakretički znakovi...UTF-32=možemo koristiti bilo koje znakove

            //double četrdeset\u0161est = 46.0;
            //greška zbog istog imena i zbog unicoda ali se ne preporučuje
            
            int бројШест = 6;            //i ovo je regularno

            
            string 你好 = "nihao";            //prolazi

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
