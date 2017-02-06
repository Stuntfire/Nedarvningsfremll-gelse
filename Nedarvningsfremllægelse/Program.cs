using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedarvningsfremllægelse
{
    class Program
    {
        static void Main(string[] args)
        {

            Bil nyBil = new Bil("BMW", 100000, 2013, 15);
            Console.WriteLine(nyBil.BilPrisExAfgift);
            //Console.WriteLine(nyBil.RegistreringsAfgift());
            Console.WriteLine(nyBil.TotalPris());
        }
    }
}
