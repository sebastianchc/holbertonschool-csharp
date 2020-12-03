using System;
using System.Collections.Generic;

class List
{
	public static int MaxInteger(List<int> myList)
	{
		int max = myList[0];

		foreach (var n in myList)
		{
			if (n > max)
			{
				max = n;
			}
		}
		return(max);
	}
}