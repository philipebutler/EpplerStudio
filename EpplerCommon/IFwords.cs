using System;

namespace EpplerCommon
{
	public interface IFwords
	{
		void Add(IEpplerWord word);
		void Remove(int index);
		string getFwords();
	}
}

