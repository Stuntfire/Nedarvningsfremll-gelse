using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedarvningsfremllægelse
{
    class ElBil : Bil
    {
        public int BatteriKapacitet { get; set; }
        public int KmPrKW { get; set; }
        public ElBil(string mærke, int bilPrisExAfgift, int købsår, string registreringsNr, int batterikapacitet, int kmPrKw) : base(mærke, bilPrisExAfgift, købsår, /*kmPrLiter,*/ registreringsNr)
        {
            this.BatteriKapacitet = batterikapacitet;
            this.KmPrKW = kmPrKw;
        }

        public override int HalvÅrligEjerafgift()
        {
            return 0;
        }

        public override int Rækkevidde()
        {
            return BatteriKapacitet * KmPrKW;
        }

        public override int RegistreringsAfgift()
        {
            return base.RegistreringsAfgift() * 20 / 100;
        }

        public override string HvilkenBilErJeg()
        {
            return "Jeg er en Class Elbil";
        }
    }
}
