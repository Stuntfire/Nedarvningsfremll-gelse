﻿using System;
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
            if (PartikelFilter)
            {
                if (KmPrLiter < 15)
                {
                    return 2000;
                }
                else if (KmPrLiter > 15 && KmPrLiter < 25)
                {
                    return 1000;
                }
                else
                    return 350;
            }

            else
            {
                if (KmPrLiter < 15)
                {
                    return 2500;
                }
                else if (KmPrLiter > 15 && KmPrLiter < 25)
                {
                    return 1500;
                }
                else
                    return 850;
            }



        }

        // Sådan så metoden ud inden Bil.cs blev ændret til abstract
        //public override int HalvÅrligEjerafgift()
        //{
        //    //return 1200;
        //    // virker kun hvis base metoden er sat til virtual
        //    if (!PartikelFilter)
        //    {
        //        return base.HalvÅrligEjerafgift() + 500;
        //    }
        //    return base.HalvÅrligEjerafgift();
        //}
    }
}
