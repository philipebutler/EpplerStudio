using System;

namespace EpplerCommon
{
	public static class ArrayExtensions
	{
		public ArrayExtensions ()
		{
		}
		
		[System.Runtime.CompilerServices.Extension()]
		public object[] SubArray(object[] a, int StartElement, int EndElement)
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

