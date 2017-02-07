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
                //Console.WriteLine(bb.BilPrisExAfgift);
                Console.WriteLine($"Din {bb.Mærke} er fra {bb.KøbsÅr} og før afgift koster den {bb.BilPrisExAfgift} kr., har en totalpris på: {bb.TotalPris()} kr. kører {bb.KmPrLiter} pr/l, derfor skal du betale {bb.HalvÅrligEjerafgift()} kr. i halvårlig ejerafgift");
                Console.WriteLine(bb.Rækkevidde());
            }

            // Her kommer en liste over elbiler:
            List<ElBil> elBilList = new List<ElBil>();

            ElBil eB01 = new ElBil("Rimac", 800000, 2017, "EB 99401", 82, 8);
            ElBil eB02 = new ElBil("Tesla", 800000, 2017, "EB 99401", 90, 8);
            ElBil eB03 = new ElBil("Nissan Leaf", 800000, 2017, "EB 99401", 82, 8);
            ElBil eB04 = new ElBil("Tesla 3", 800000, 2017, "EB 99401", 75, 8);
            ElBil eB05 = new ElBil("Chevy Bolt EV", 100000, 2017, "EB 99401", 82, 8);

            elBilList.Add(eB01);
            elBilList.Add(eB02);
            elBilList.Add(eB03);
            elBilList.Add(eB04);
            elBilList.Add(eB05);

            foreach (ElBil elbil in elBilList)
            {
                Console.WriteLine(elbil.Rækkevidde());
                Console.WriteLine(elbil.RegistreringsAfgift());
            }

            // Her laver vi en liste der samler alle vores biler:
            List<IBil> bilList = new List<IBil>();

            bilList.Add(dB01);
            bilList.Add(dB02);
            bilList.Add(dB03);
            bilList.Add(dB04);
            bilList.Add(dB05);
            bilList.Add(dB06);
            bilList.Add(bB01);
            bilList.Add(bB02);
            bilList.Add(bB03);
            bilList.Add(bB04);
            bilList.Add(bB05);
            bilList.Add(eB01);
            bilList.Add(eB02);
            bilList.Add(eB03);
            bilList.Add(eB04);
            bilList.Add(eB05);

            foreach (Bil bil in bilList)
            {
                if (bil is DieselBil)
                {
                    DieselBil dieselbil = bil as DieselBil;
                    Console.WriteLine(dieselbil.PartikelFilter);
                    Console.WriteLine(dieselbil.HvilkenBilErJeg());
                }
                else if (bil is BenzinBil)
                {
                    BenzinBil benzinBil = bil as BenzinBil;
                    Console.WriteLine(benzinBil.Oktan);
                    Console.WriteLine(benzinBil.HvilkenBilErJeg());
                }
                else
                {
                    if (typeof(ElBil).GetInterfaces().Contains(typeof(IelMotor)))
                    {
                        ElBil elbil = bil as ElBil;
                        Console.WriteLine(elbil.BatteriKapacitet);
                        Console.WriteLine(elbil.HvilkenBilErJeg());
                        Console.WriteLine(elbil.BilPrisExAfgift);
                        Console.WriteLine(elbil.TotalPris());
                        Console.WriteLine(elbil.LadeTid());
                    }

                }

            }

            //Bil nyBil = new Bil("BMW", 100000, 2015, 15, "XY 54871");
            //Console.WriteLine(nyBil.BilPrisExAfgift);
            //Console.WriteLine(nyBil.RegistreringsAfgift());
            //Console.WriteLine(nyBil.TotalPris());


        }
    }
}
