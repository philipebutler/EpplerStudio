using System;
using EpplerCommon;
using EpplerCommon.Extensions;

namespace EpplerIO
{
	public class Word : IEpplerWord
	{
		public Word ()
		{
		}
		
		public Word(Single value)
		{
			if (value > 999)
			{
				throw new Exception("Word value " + value + " is invalid");
			}else {
				Value = value;
			}
			
		}
		
		public Single Value 
		{
			get{
				
				return Value;
			}
			set {
				if (value > 999) 
				{
					throw new Exception("Fword value " + value + " is not valid");
				}else{
					Value = value;
				}
			}
		}
		
		public WordFormat Format;
		public WordPosition Position;
		public string Name;
		
		public int ToInteger()
		{
			string StringValue = Value.ToString;
			string wholeString = StringValue.Split(".").SubArray(0,0).ToString;
			string decimalString = StringValue.Split(".").SubArray(1,1).ToString;
			
			
			return System.Convert.ToInt32(wholeString + decimalString.Substring(0,2));
		}
		
		
		public string ToString()
		{
			string result = string.Empty;
			string frontSpace  = string.Empty;
			string stringValue = Value.ToString;
			bool hasDecimal = stringValue.Contains(".");
			
			if(hasDecimal)
			{
				for (int i = 5;i>=0;i -= 1)
				{
					if(i >= stringValue.Length)
					{
						frontSpace += " ";
					}else if(!stringValue.Substring(i,1) == "."){
						result = stringValue.Substring(i,1) + result;
					}
				}
			}else{
				//TODO: add output capability for F5.0 format
				//TODO: add output capability for F5.1 format
				//TODO: add output capability for F5.4 format
				
				if(Format == WordFormat.F5p0)
				{
				}else if (Format == WordFormat.F5p1){
				}else if (Format == WordFormat.F5p2){
					for(int i = 3; i >= 0; i -= 1)
					{
						if(i >= stringValue.Length)
						{
							frontSpace += " ";
						}else{
							result = stringValue.Substring(i,1) + result;
						}
					}
					result += "00";
				}else if (Format == WordFormat.F5p3){
					for(int i = 2; i >= 0; i -= 1)
					{
						if(i >= stringValue.Length)
						{
							frontSpace += " ";
						}else{
							result = stringValue.Substring(i,1) + result;
						}
					}
					result += "000";					
				}else if (Format == WordFormat.F5p4){
				}
					
			}
			
			
			return frontSpace + result;
		}
		
	}
}

