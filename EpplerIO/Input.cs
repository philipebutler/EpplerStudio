using System;
namespace EpplerIO
{
	
	public interface IEpplerInput {
		void Read(string FileName);
		void Write(string FileName);
	}
	
	public class Input : IEpplerInput
	{
		public Input ()
		{
		}
		
		public void Read(string FileName) {
			throw new Exception("No Input to read");
		}
		
		public void Write(string FileName) {
			throw new Exception("No Input to write");
		}
	}
}

