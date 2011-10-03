using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EpplerIO.Cards
{
    class DIAG : EpplerCard
    {
        public DIAG()
        {
            this.init();
        }

        public DIAG(string cardString)
        {
            this.init();
            this.Load(cardString);
        }

        private void init()
        {
            CardType = EpplerCommon.CardType.AirfoilDesign;
            Name = "DIAG";
            Description = "Initiates the plotting of two different diagrams.";
        }

        new bool MultipleAllowed
        {
            get
            {
                return true;
            }
        }

        new void Load(string card)
        {
            this.Name = card.Substring(0, 4);

            string localNUPI = card.Substring(6, 1);
            this.NUPI = Convert.ToInt32(localNUPI);

            string localNUPU = card.Substring(7, 3);
            this.NUPU = Convert.ToInt32(localNUPU);
        }
    }
}
