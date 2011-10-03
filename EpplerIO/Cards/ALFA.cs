using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EpplerIO.Cards
{
    class ALFA : EpplerCard
    {
        private WordSeries words;

        public ALFA()
        {
            this.init();
        }

        public ALFA(string cardString)
        {
            this.init();
            this.Load(cardString);
        }

        private void init()
        {
            this.CardType = EpplerCommon.CardType.AirfoilDesign;
            this.Name = "ALFA";
            this.Description = "1. initiates the storage of up to 14 values of alpha, pitching moment and hinge moment coefficients. ";
            Description += " 2. it initiates the additional output called the x-y-v listing, printed according to print mode mxy";
            words = new WordSeries();
        }

        public override string ToString()
        {
            string fwords = null;
            foreach( Word w in words.Words)
            {
                fwords += w.ToString();
            }

            return Name + NUPA.ToString() + NUPE.ToString() + NUPI.ToString() + NUPU.ToString() + fwords;
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
            
            string localNUPA = card.Substring(4,1);
            this.NUPA = Convert.ToInt32(localNUPA);

            string localNUPE = card.Substring(5, 1);
            this.NUPE = Convert.ToInt32(localNUPE);

            string localNUPI = card.Substring(6, 1);
            this.NUPI = Convert.ToInt32(localNUPI);

            string localNUPU = card.Substring(7, 3);
            this.NUPU = Convert.ToInt32(localNUPU);

            try
            {
                Word newWord;
                for (int i = 10; i <= card.Length - 1; i += 5)
                {
                    if (i == 10)
                    {
                        newWord = new Word {Name = "alpha i", Position = EpplerCommon.WordPosition.F1, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i,5))};
                        words.Add(newWord);
                    }
                    else if (i == 15)
                    {
                        newWord = new Word { Name = "alpha i", Position = EpplerCommon.WordPosition.F2, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 20)
                    {
                        newWord = new Word { Name = "alpha i", Position = EpplerCommon.WordPosition.F3, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 25)
                    {
                        newWord = new Word { Name = "alpha i", Position = EpplerCommon.WordPosition.F4, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 30)
                    {
                        newWord = new Word { Name = "alpha i", Position = EpplerCommon.WordPosition.F5, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 35)
                    {
                        newWord = new Word { Name = "alpha i", Position = EpplerCommon.WordPosition.F6, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 40)
                    {
                        newWord = new Word { Name = "alpha i", Position = EpplerCommon.WordPosition.F7, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 45)
                    {
                        newWord = new Word { Name = "alpha i", Position = EpplerCommon.WordPosition.F8, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 50)
                    {
                        newWord = new Word { Name = "alpha i", Position = EpplerCommon.WordPosition.F9, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 55)
                    {
                        newWord = new Word { Name = "alpha i", Position = EpplerCommon.WordPosition.F10, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 60)
                    {
                        newWord = new Word { Name = "alpha i", Position = EpplerCommon.WordPosition.F11, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 65)
                    {
                        newWord = new Word { Name = "alpha i", Position = EpplerCommon.WordPosition.F12, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 70)
                    {
                        newWord = new Word { Name = "alpha i", Position = EpplerCommon.WordPosition.F13, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 75)
                    {
                        newWord = new Word { Name = "alpha i", Position = EpplerCommon.WordPosition.F14, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
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
