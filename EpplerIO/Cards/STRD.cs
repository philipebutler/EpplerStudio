using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EpplerIO.Cards
{
    class STRD : EpplerCard
    {
        private WordSeries words;

        public STRD()
        {
            this.init();
        }

        public STRD(string cardString)
        {
            this.init();
            this.Load(cardString);
        }

        private void init()
        {
            CardType = EpplerCommon.CardType.AirfoilAnalysis;
            Name = "STRD";
            Description = "Prepares the data for the plotting of airfoils having various chord lengths.";
            Deprecated = true;
            words = new WordSeries();
        }

        new public bool MultipleAllowed
        {
            get
            {
                return false;
            }
        }

        new public void Load(string card)
        {
            this.Name = card.Substring(0, 4);

            string localNUPU = card.Substring(7, 3);
            this.NUPU = Convert.ToInt32(localNUPU);

            try
            {
                Word newWord;
                for (int i = 10; i <= card.Length - 1; i += 5)
                {
                    if (i == 10)
                    {
                        newWord = new Word { Name = "YBL, vertical extent of the plot(mm)", Position = EpplerCommon.WordPosition.F1, Format = EpplerCommon.WordFormat.F5p0, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 15)
                    {
                        newWord = new Word { Name = "RUA, veritcal shift of the chord line(mm)", Position = EpplerCommon.WordPosition.F2, Format = EpplerCommon.WordFormat.F5p0, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO: implement message passing
                //MessageBox.show(ex.Message);
            }
        }
    }
}
