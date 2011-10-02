using System;
using EpplerCommon;
using EpplerCommon.Extensions;

namespace EpplerIO
{
	public class ABSZ : EpplerCard
	{
		WordSeries words;
		
		public ABSZ ()
		{
			this.init();
		}
		
		public ABSZ(string cardString)
		{
			this.init();
			this.Load(cardString);
		}
		
		void init()
		{
			CardType = CardType.AirfoilAnalysis;
			Name = "ABSZ";
			Description = "Specifies the the print mode and the number of points used in the design subroutine.";
			words = new WordSeries();
		}
		
		new public bool MultipleAllowed
		{
			get 
			{
				return  false;
			} 
		}
	
		new public void Load(string card)
		{
            string localNUPE = card.Substring(5, 1);
			this.Name = card.Substring(0,4);
			this.NUPE = Convert.ToInt32(localNUPE);
			
			try
			{
				Word newWord;
				for(int i = 10;i<=card.Length-1;i += 5)
				{
                    if (i == 15)
                    {
                        newWord = new Word { Name = "ABFA", Position = WordPosition.F2, Format = WordFormat.F5p2, Value = Convert.ToSingle(card.Substring(i, 5)) };
                        words.Add(newWord);
                    }
				}
			}catch (Exception ex){
				//TODO: get output of ex.message
			}
		}
	
		public override string ToString()
		{
			string fwords = string.Empty;
			foreach( Word w in words.Words)
			{
				fwords += w.ToString();
			}
			return Name + NUPA.ToString() + NUPE.ToString() + NUPI.ToString() + NUPU.ToString() + fwords; 
		}
	}
}

