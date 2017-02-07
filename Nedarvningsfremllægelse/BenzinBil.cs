using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedarvningsfremllægelse
{
    sealed class BenzinBil : Bil
    {
        public int Tank { get; set; }

        public BenzinBil(string mærke, int bilPrisExAfgift, int købsår, int kmPrLiter, string registreringsNr, int tank) 
            : base(mærke, bilPrisExAfgift, købsår, kmPrLiter, registreringsNr)
        {
            this.Tank = tank;
        }

        public override int HalvÅrligEjerafgift()
        {
            if (KmPrLiter < 20)
            {
                return 1200;
            }
            else if (KmPrLiter >= 20 && KmPrLiter <= 28)
            {
                return 600;
            }
            else
                return 320;
        }

        public override string HvilkenBilErJeg()
        {
            return "Jeg er en Class BenzinBil";
        }

        public override int Rækkevidde()
        {
            return Tank * KmPrLiter;
        }
    }
}
