using System;
using System.Collections.Generic;

class List
{
	public static int MaxInteger(List<int> myList)
	{
		if (myList == null || myList.Count == 0)
		{
			Console.WriteLine("List is empty");
			return(-1);
		}
		else
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
}