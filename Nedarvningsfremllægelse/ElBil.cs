using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedarvningsfremllægelse
{
    class ElBil : Bil
    {
        public ElBil(string mærke, int bilPrisExAfgift, int købsår, int kmPrLiter, string registreringsNr) : base(mærke, bilPrisExAfgift, købsår, kmPrLiter, registreringsNr)
        {
        }

        public override int HalvÅrligEjerafgift()
        {
            throw new NotImplementedException();
        }

        public override int Rækkevidde()
        {
            throw new NotImplementedException();
        }
    }
}
