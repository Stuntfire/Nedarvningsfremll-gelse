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
        public DieselBil(int pris, bool pf) : base(pris)
        {
            this.PartikelFilter = pf;
        }

        public DieselBil(int pris) : this(pris, true)
        {

        }

        //public override int Afgift()
        //{
        //    return 1200;
        //    // virker kun hvis base metoden er sat til virtual
        //    //return base.Afgift() + 200;
        //}
    }
}
