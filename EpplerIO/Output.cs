using System;
namespace EpplerIO
{
	
	public interface IEpplerOutput {
		void Read(string FileName);
	}
	public class Output : IEpplerOutput
	{
		public Output ()
		{
		}
		
		public void Read(string FileName) {
			throw new Exception("No output to read");
		}
	}
}

