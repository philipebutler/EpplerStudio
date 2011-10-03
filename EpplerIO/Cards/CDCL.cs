using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EpplerIO.Cards
{
    class CDCL : EpplerCard
    {

        private WordSeries words;

        public CDCL()
        {
            this.init();
        }

        public CDCL(string cardString)
        {
            this.init();
            this.Load(cardString);
        }

        private void init()
        {
            CardType = EpplerCommon.CardType.BoundaryLayerOptions;
            Name = "CDCL";
            Description = "Initiates the plotting of the boundary-layer summary: lift, drag, and pitching moment.";
            words = new WordSeries();
        }

        new public  bool MultipleAllowed
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

            try
            {
                Word newWord;
                for (int i = 10; i <= card.Length - 1; i += 5)
                {
                    if (i == 10)
                    {
                        if (this.NUPA == 1)
                        {
                            newWord = new Word { Name = "Five digits denoted n1 to n5", Position = EpplerCommon.WordPosition.F1, Format = EpplerCommon.WordFormat.F5p0, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        }
                        else
                        {
                            newWord = new Word { Name = "cl,min = lower limit of lift coefficient", Position = EpplerCommon.WordPosition.F1, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        }

                        words.Add(newWord);
                    }
                    else if (i == 15)
                    {
                        if (this.NUPA == 1)
                        {
                            newWord = new Word { Name = "Five digits denoted n1 to n5", Position = EpplerCommon.WordPosition.F2, Format = EpplerCommon.WordFormat.F5p0, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        }
                        else
                        {
                            newWord = new Word { Name = "cl,max = upper limit of lift coefficient", Position = EpplerCommon.WordPosition.F2, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        }

                        words.Add(newWord);
                    }
                    else if (i == 20)
                    {
                        if (this.NUPA == 1)
                        {
                            newWord = new Word { Name = "li = the length of the plot line or the space(mm)", Position = EpplerCommon.WordPosition.F3, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                            words.Add(newWord);
                        }
                    }
                    else if (i == 25)
                    {
                        if (this.NUPA == 1)
                        {
                            newWord = new Word { Name = "li = the length of the plot line or the space(mm)", Position = EpplerCommon.WordPosition.F4, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        }
                        else
                        {
                            newWord = new Word { Name = "cd,lim = upper limit of the drag coefficient", Position = EpplerCommon.WordPosition.F4, Format = EpplerCommon.WordFormat.F5p4, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        }

                        words.Add(newWord);
                    }
                    else if (i == 30)
                    {
                        newWord = new Word { Name = "li = the length of the plot line or the space(mm)", Position = EpplerCommon.WordPosition.F5, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 35)
                    {
                        newWord = new Word { Name = "li = the length of the plot line or the space(mm)", Position = EpplerCommon.WordPosition.F6, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 40)
                    {
                        newWord = new Word { Name = "li = the length of the plot line or the space(mm)", Position = EpplerCommon.WordPosition.F7, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 45)
                    {
                        newWord = new Word { Name = "li = the length of the plot line or the space(mm)", Position = EpplerCommon.WordPosition.F8, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 50)
                    {
                        newWord = new Word { Name = "li = the length of the plot line or the space(mm)", Position = EpplerCommon.WordPosition.F9, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 55)
                    {
                        newWord = new Word { Name = "li = the length of the plot line or the space(mm)", Position = EpplerCommon.WordPosition.F10, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 60)
                    {
                        newWord = new Word { Name = "li = the length of the plot line or the space(mm)", Position = EpplerCommon.WordPosition.F11, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 65)
                    {
                        newWord = new Word { Name = "li = the length of the plot line or the space(mm)", Position = EpplerCommon.WordPosition.F12, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 70)
                    {
                        newWord = new Word { Name = "li = the length of the plot line or the space(mm)", Position = EpplerCommon.WordPosition.F13, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
                    else if (i == 75)
                    {
                        newWord = new Word { Name = "li = the length of the plot line or the space(mm)", Position = EpplerCommon.WordPosition.F14, Format = EpplerCommon.WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
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
