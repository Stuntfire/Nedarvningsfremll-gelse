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
            
            DieselBil dB01 = new DieselBil("Lexus", 120000, 2012, 14, "AA 78501", true);
            DieselBil dB02 = new DieselBil("Lexus", 120000, 2012, 20, "AA 78502", true);
            DieselBil dB03 = new DieselBil("Lexus", 120000, 2012, 28, "AA 78503", true);
            DieselBil dB04 = new DieselBil("Lexus", 120000, 2012, 14, "AA 78504", false);
            DieselBil dB05 = new DieselBil("Lexus", 120000, 2012, 20, "AA 78505", false);
            DieselBil dB06 = new DieselBil("Lexus", 120000, 2012, 28, "AA 78505", false);

            List<DieselBil> dieselBiler = new List<DieselBil>();

            dieselBiler.Add(dB01);
            dieselBiler.Add(dB02);
            dieselBiler.Add(dB03);
            dieselBiler.Add(dB04);
            dieselBiler.Add(dB05);
            dieselBiler.Add(dB06);

            foreach (DieselBil db in dieselBiler)
            {
                Console.WriteLine(db.RegistreringsNr + ": " + db.HalvÅrligEjerafgift() + " kr. i halvårlig ejerafgift");
                //Console.WriteLine(db.HalvÅrligEjerafgift());
            }

            //Bil nyBil = new Bil("BMW", 100000, 2015, 15, "XY 54871");
            //Console.WriteLine(nyBil.BilPrisExAfgift);
            //Console.WriteLine(nyBil.RegistreringsAfgift());
            //Console.WriteLine(nyBil.TotalPris());


        }
    }
}
