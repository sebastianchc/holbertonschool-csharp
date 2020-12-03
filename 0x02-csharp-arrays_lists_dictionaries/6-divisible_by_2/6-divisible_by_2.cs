using System;
using System.Collections.Generic;

class List
{
	public static List<bool> DivisibleBy2(List<int> myList)
	{
		var array = new List<bool>();
		foreach (var number in myList)
		{
			if (number % 2 == 0)
			{
				array.Add(true);
			}
			else
			{
				array.Add(false);
			}
		}
		return(array);
	}
}