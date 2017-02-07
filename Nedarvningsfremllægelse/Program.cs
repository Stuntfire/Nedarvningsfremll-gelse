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
            
            DieselBil dB01 = new DieselBil("Lexus", 120000, 2012, 14, "DB 78501", true, 50);
            DieselBil dB02 = new DieselBil("Lexus", 120000, 2012, 20, "DB 78502", true, 50);
            DieselBil dB03 = new DieselBil("Lexus", 120000, 2012, 28, "DB 78503", true, 50);
            DieselBil dB04 = new DieselBil("Lexus", 120000, 2012, 14, "DB 78504", false, 50);
            DieselBil dB05 = new DieselBil("Lexus", 120000, 2012, 20, "DB 78505", false, 50);
            DieselBil dB06 = new DieselBil("Lexus", 120000, 2012, 28, "DB 78505", false, 50);

            List<DieselBil> dieselBilList = new List<DieselBil>();

            dieselBilList.Add(dB01);
            dieselBilList.Add(dB02);
            dieselBilList.Add(dB03);
            dieselBilList.Add(dB04);
            dieselBilList.Add(dB05);
            dieselBilList.Add(dB06);

            foreach (DieselBil db in dieselBilList)
            {
                Console.WriteLine(db.RegistreringsNr + ": " + db.HalvÅrligEjerafgift() + " kr. i halvårlig ejerafgift");
                Console.WriteLine(db.Rækkevidde());
            }

            // Her kommer en liste over benzin biler:
            BenzinBil bB01 = new BenzinBil("Maserati", 600000, 2012, 9, "BB 54801", 50);
            BenzinBil bB02 = new BenzinBil("Audi", 400000, 2012, 19, "BB 54802", 50);
            BenzinBil bB03 = new BenzinBil("BMW", 300000, 2012, 20, "BB 54803", 50);
            BenzinBil bB04 = new BenzinBil("Renault", 200000, 2012, 28, "BB 54804", 50);
            BenzinBil bB05 = new BenzinBil("Toyota", 100000, 2012, 29, "BB 54805", 50);

            List<BenzinBil> benzinBilList = new List<BenzinBil>();

            benzinBilList.Add(bB01);
            benzinBilList.Add(bB02);
            benzinBilList.Add(bB03);
            benzinBilList.Add(bB04);
            benzinBilList.Add(bB05);

            foreach (BenzinBil bb in benzinBilList)
            {
                Console.WriteLine(bb.BilPrisExAfgift);
                Console.WriteLine($"Din {bb.Mærke} er fra {bb.KøbsÅr}, har en totalpris på: {bb.TotalPris()} kr. kører {bb.KmPrLiter} pr/l, før afgift koster den {bb.BilPrisExAfgift} kr.");
                Console.WriteLine($"{bb.HalvÅrligEjerafgift()} kr. koster din {bb.Mærke} i halvårlig ejerafgift");
                Console.WriteLine(bb.Rækkevidde());
            }

            //List<Bil> bilList = new List<Bil>();

            //foreach (Bil bil in bilList)
            //{
            //    if (bil is DieselBil)
            //    {
            //        DieselBil dieselbil = bil as DieselBil;
            //        Console.WriteLine(dieselbil.PartikelFilter);
            //    }
            //    else if (bil is BenzinBil)
            //    {
            //        BenzinBil benzinBil = bil as BenzinBil;
            //        Console.WriteLine(benzinBil.Oktan);
            //    }

            //}

            //Bil nyBil = new Bil("BMW", 100000, 2015, 15, "XY 54871");
            //Console.WriteLine(nyBil.BilPrisExAfgift);
            //Console.WriteLine(nyBil.RegistreringsAfgift());
            //Console.WriteLine(nyBil.TotalPris());


        }
    }
}
