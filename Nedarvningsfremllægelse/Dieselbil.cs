using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedarvningsfremllægelse
{
    class DieselBil : Bil
    {
        public bool PartikelFilter { get; private set; }

        public DieselBil(string mærke, int bilPrisExAfgift, int købsår, int kmPrLiter, string registreringsNr, bool partikelFilter) 
            : base(mærke, bilPrisExAfgift, købsår, kmPrLiter, registreringsNr)
        {
            this.PartikelFilter = partikelFilter;
        }

        public DieselBil(string mærke, int bilPrisExAfgift, int købsår, int kmPrLiter, string registreringsNr) 
            : this(mærke, bilPrisExAfgift, købsår, kmPrLiter, registreringsNr, true)
        {

        }

        public override int HalvÅrligEjerafgift()
        {
            //return 1200;
            // virker kun hvis base metoden er sat til virtual
            if (!PartikelFilter)
            {
                return base.HalvÅrligEjerafgift() + 500;
            }
            return base.HalvÅrligEjerafgift();
        }
    }
}
