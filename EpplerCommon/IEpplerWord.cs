using System;

namespace EpplerCommon
{
	public interface IEpplerWord
	{
		Single Value {get;set;}
		WordFormat Format {get;set;}
		WordPosition Position {get;set;}
		string Name {get; set;}
		
		int ToInteger();
		string ToString();
	}
}

