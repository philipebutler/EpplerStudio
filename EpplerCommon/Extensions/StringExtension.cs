using System;

namespace EpplerCommon
{
	public static class StringExtension
	{

		public static string Left(this string s,int count)
		{
			return s.Substring(0,count);
		}
		
		public static string RemSpace(this string s)
		{
			if (s.Contains("  "))
			{
				s = s.Replace("  "," ");
				s = s.RemSpace();
			}
			
			return s;
		}
		
		public static string Remove(this string s, string characters)
		{
			if (s.Contains(characters))
			{
				s = s.Replace(characters,"");
				s = s.Remove(characters);
			}
			
			return s;
		}
	}
}

