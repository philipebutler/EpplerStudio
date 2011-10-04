using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EpplerIO.Cards
{
    class PLW : EpplerCard
    {
        private WordSeries words;

        private void init()
        {
            CardType = EpplerCommon.CardType.BoundaryLayerOptions;
            Name = "PLW";
            Description = "Initiates and aircraft-oriented boundary-layer computation which uses";
            Description += "the given aircraft data and results in a polar or the aircraft.";
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
                        newWord = new Word { Name = "t*/c = reference airfoil thickness", Position = EpplerCommon.WordPosition.F1, Format = EpplerCommon.WordFormat.F5p4, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 15)
                    {
                        newWord = new Word { Name = "W* = the aircraft mass(kg)", Position = EpplerCommon.WordPosition.F2, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 20)
                    {
                        newWord = new Word { Name = "DWS = the mass penalty factor(kg/m2)", Position = EpplerCommon.WordPosition.F3, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 25)
                    {
                        newWord = new Word { Name = "Ap = the parasite-drag area(m2)", Position = EpplerCommon.WordPosition.F4, Format = EpplerCommon.WordFormat.F5p5, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 30)
                    {
                        newWord = new Word { Name = "c* = chord length(m)", Position = EpplerCommon.WordPosition.F5, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 35)
                    {
                        newWord = new Word { Name = "db = spanwise section length having chord c* (m)", Position = EpplerCommon.WordPosition.F6, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 40)
                    {
                        newWord = new Word { Name = "c* = chord length(m)", Position = EpplerCommon.WordPosition.F7, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 45)
                    {
                        newWord = new Word { Name = "db = spanwise section length having chord c* (m)", Position = EpplerCommon.WordPosition.F8, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 50)
                    {
                        newWord = new Word { Name = "c* = chord length(m)", Position = EpplerCommon.WordPosition.F9, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 55)
                    {
                        newWord = new Word { Name = "db = spanwise section length having chord c* (m)", Position = EpplerCommon.WordPosition.F10, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 60)
                    {
                        newWord = new Word { Name = "c* = chord length(m)", Position = EpplerCommon.WordPosition.F11, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 65)
                    {
                        newWord = new Word { Name = "db = spanwise section length having chord c* (m)", Position = EpplerCommon.WordPosition.F12, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 70)
                    {
                        newWord = new Word { Name = "c* = chord length(m)", Position = EpplerCommon.WordPosition.F13, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 75)
                    {
                        newWord = new Word { Name = "db = spanwise section length having chord c* (m)", Position = EpplerCommon.WordPosition.F14, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
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
