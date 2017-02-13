using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedarvningsfremllægelse
{
    abstract class Bil : IBil
    {
        // props
        public int BilPrisExAfgift { get; private set; }

        public int KøbsÅr { get; private set; }

        public string Mærke { get; set; }

        public string RegistreringsNr { get; set; }

        //public int KmPrLiter { get; set; }

        public int Oktan { get; set; }

        // ctor
        public Bil(string mærke, int bilPrisExAfgift, int købsår, /*int kmPrLiter,*/ string registreringsNr)
        {
            this.Mærke = mærke;
            this.BilPrisExAfgift = bilPrisExAfgift;
            this.KøbsÅr = købsår;
            //this.KmPrLiter = kmPrLiter;
            this.RegistreringsNr = registreringsNr;
        }

        // methods
        public virtual int RegistreringsAfgift()
        {
            int lavAfgift = 0;
            int højAfgift = 0;

            if (KøbsÅr <= 2014)
            {
                if (BilPrisExAfgift <= 80500)
                {
                    BilPrisExAfgift = BilPrisExAfgift * (105 / 100);
                }
                else
                {
                    lavAfgift = BilPrisExAfgift * (105 / 100);
                    højAfgift = (BilPrisExAfgift - 80500) * (180 / 100);
                    this.BilPrisExAfgift = lavAfgift + højAfgift;
                }
                return this.BilPrisExAfgift;
            }

            else
            {
                if (BilPrisExAfgift <= 81700)
                {
                    BilPrisExAfgift = BilPrisExAfgift * (105 / 100);
                }
                else
                {
                    lavAfgift = BilPrisExAfgift * (105 / 100);
                    højAfgift = (BilPrisExAfgift - 81700) * (180 / 100);
                    this.BilPrisExAfgift = lavAfgift + højAfgift;
                }
                return this.BilPrisExAfgift;
            }
        }

        public int TotalPris()
        {
            return BilPrisExAfgift + RegistreringsAfgift();
        }

        public abstract int HalvÅrligEjerafgift();

        public abstract int Rækkevidde();

        public virtual string HvilkenBilErJeg()
        {
            return "Jeg er en Class Bil";
        }
    }
}
