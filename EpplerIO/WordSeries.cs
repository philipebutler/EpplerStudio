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
		
		private List<Word> words;
		public List<Word> Words {
			get
			{
				return words;
			}
		}
		
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
		
		public void Add(EpplerIO.Word word)
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
			return Words.ToString();
		}
		
	}
}

