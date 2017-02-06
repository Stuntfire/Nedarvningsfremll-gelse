using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedarvningsfremllægelse
{
    public class Bil
    {
        public int BilPrisExAfgift { get; private set; }

        public int KøbsÅr { get; private set; }

        public string Mærke { get; set; }

        public string RegistreringsNr { get; set; }

        public int KmPrLiter { get; set; }


        public Bil(int pris)
        {
            this.BilPrisExAfgift = pris;
        }

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

        public virtual int HalvÅrligEjerafgift()
        {
            return 1000;
        }

        public Bil(string mærke, int bilPrisExAfgift, int købsår, int kmPrLiter)
        {
            this.Mærke = mærke;
            this.BilPrisExAfgift = bilPrisExAfgift;
            this.KøbsÅr = købsår;
            this.KmPrLiter = kmPrLiter;
        }
    }
}
