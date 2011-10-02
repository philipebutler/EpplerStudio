using System;
using EpplerCommon;

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
		
		public override bool MultipleAllowed
		{
			get 
			{
				return  false;
			}
		}
	
		public void Load(string card)
		{
			this.Name = card.Substring(0,4);
			this.NUPE = card.Substring(5,1).ToInteger;
			
			try
			{
				Word newWord;
				for(int i = 10;i<=card.Length-1;i += 5)
				{
					switch(i)
					{
					case 15 :
							newWord = new Word {Name = "ABFA", Position = WordPosition.F2,Format = WordFormat.F5p2,Value = card.Substring(i,5).ToSingle};
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
				fwords += w.ToString;
			}
			return Name + NUPA.ToString + NUPE.ToString + NUPI.ToString + NUPU.ToString + fwords; 
		}
	}
}

