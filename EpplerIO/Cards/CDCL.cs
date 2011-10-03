using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EpplerIO.Cards
{
    class CDCL : EpplerCard
    {

        private WordSeries words;

        public void CDCL()
        {
            this.init();
        }

        public void CDCL(string cardString)
        {
        }

        private void init()
        {
            CardType = EpplerCommon.CardType.BoundaryLayerOptions;
            Name = "CDCL";
            Description = "Initiates the plotting of the boundary-layer summary: lift, drag, and pitching moment.";
            words = new WordSeries();
        }

        new public string ToString()
        {
            return base.ToString();
        }

        new public  bool MultipleAllowed
        {
            get
            {
                return false;
            }
        }

        public void Load(string card)
        {

        }
    }
}
