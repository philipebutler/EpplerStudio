using System;

namespace EpplerCommon
{
	namespace Extensions{
	public static class ArrayExtensions
	{
		
		public static object[] SubArray(this object[] a, int StartElement, int EndElement)
		{
			object[] b = new object[EndElement - StartElement + 1];
			int j = 0;
			for (int i = StartElement; i <= EndElement; i++) {
				b[j] = a[i];
				j += 1;
			}
			return b;
		}
	}
	}
}

