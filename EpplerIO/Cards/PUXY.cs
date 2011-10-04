using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EpplerIO.Cards
{
    class PUXY : EpplerCard
    {

        private void init()
        {
            CardType = EpplerCommon.CardType.AirfoilAnalysis;
            Name = "PUXY";
            Description = "Switches the program from design mode to analysis mode, required to run panel method if no FXPR card is used.";
            Deprecated = true;
        }

        new public string ToString()
        {
            return Description;
        }

        new public bool MultipleAllowed
        {
            get
            {
                return false;
            }
        }

    }
}
