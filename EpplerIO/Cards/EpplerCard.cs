using System;
using EpplerCommon;

namespace EpplerIO
{
	public abstract class EpplerCard : IEpplerCard
	{
		public EpplerCard ()
		{
			Deprecated = false;
		}
		
		public string Name {get; set;}
		public string Description {get; set;}
		public CardType CardType {get; set;}
		public abstract bool MultipleAllowed {get;}
		public bool Deprecated{get;set;}
		
		private int nupu;
		public int NUPU
		{ 
			get
			{
				return nupu;
			}
			set
			{
				if(value > 999)
				{
					throw new Exception("NUPU value is invalid");
				}else{
					nupu = value;
				}
			}
		}
		
		private int nupa;
		public int NUPA
		{
			get
			{
				return nupa;
			}
			set
			{
				if(value > 9)
				{
					throw new Exception("NUPA value is invalid");
				}else{
					nupa = value;
				}
			}
		}
		
		private int nupe;
		public int NUPE
		{
			get
			{
				return nupe;
			}
			set
			{
				if(value > 9)
				{
					throw new Exception("NUPE value is invalid");
				}else{
					nupe = value;
				}
			}	
		}
		
		private int nupi;
		public int NUPI
		{
			get
			{
				return nupi;
			}
			set
			{
				if(value > 9)
				{
					nupi = value;
				}
			}
		}
		
		public IFwords Fwords {get; set;}

	}
}

