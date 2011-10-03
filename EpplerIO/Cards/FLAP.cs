using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EpplerIO.Cards
{
    class FLAP : EpplerCard
    {

        WordSeries words;

        private void init()
        {
            CardType = EpplerCommon.CardType.AirfoilAnalysis;
            Name = "FLAP";
            Description = "Switches the program from design mode to analysis mode, required to run panel method if no FXPR card is used.";
            words = new WordSeries;
        }

        new public bool MultipleAllowed
        {
            get{
                return false;      
            }
        }

        new public void Load(string card)
        {

            this.Name = card.Substring(0, 4);

            try
            {
                Word newWord;

                for (int i = 10; i <= card.Length - 1; i += 5)
                {
                    if (i == 10)
                    {
                        newWord = new Word { Name = "Flap chord cf/c", Position = EpplerCommon.WordPosition.F1, Format = EpplerCommon.WordFormat.F5p4, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 15)
                    {
                        newWord = new Word { Name = "y/c-position of the flap hinge", Position = EpplerCommon.WordPosition.F2, Format = EpplerCommon.WordFormat.F5p4, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 20)
                    {
                        newWord = new Word { Name = "One half of the transition arc length st/c", Position = EpplerCommon.WordPosition.F3, Format = EpplerCommon.WordFormat.F5p4, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 25)
                    {
                        newWord = new Word { Name = "Flap deflection in degrees, positive down", Position = EpplerCommon.WordPosition.F4, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
