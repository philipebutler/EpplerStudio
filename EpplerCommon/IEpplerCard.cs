using System;

namespace EpplerCommon
{
	public interface IEpplerCard
	{
		string Name {get; set;}
		string Description {get; set;}
		CardType CardType {get; set;}
		bool MultipleAllowed { get; }
		bool Deprecated {get; set;}
		
		int NUPU {get; set;}
		int NUPA {get; set;}
		int NUPE {get; set;}
		int NUPI {get; set;}
		IFwords Fword {get; set;}
		
		String ToString();
		void Load(string Card);
	}
}

