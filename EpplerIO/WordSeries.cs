using System;
using System.Collections.Generic;
using EpplerCommon;

namespace EpplerIO
{
	public class WordSeries : IFwords
	{
		public WordSeries ()
		{

		}
		
		public List<Word> Words {get;}
		
		public void Remove(int index)
		{
			Words.RemoveAt(index);
		}
		
		public void Add(Single value)
		{
			if(Words.Count <= 14)
			{
				Words.Add(new Word(value));
			}
		}
		
		public void Add(IEpplerWord word)
		{
			if(Words.Count <= 14)
			{
				Words.Add(word);
			}
		}
		
		public void RemoveRange(int index,int count)
		{
			Words.RemoveRange(index,count);
		}
		
		public string getFwords()
		{
			return Words.ToString;
		}
		
	}
}

