using System;
using System.Collections.Generic;

class List
{
	public static List<int> CreatePrint(int size)
	{
		if (size < 0)
		{
			Console.WriteLine("Size cannot be negative");
			return(null);
		}
		var number = new List<int>();
		if (size == 0)
		{
			Console.WriteLine("");
		}
		else
		{
			for (int i = 0; i < size; i++)
			{
				number.Add(i);
				if (i == size - 1)
				{
					Console.WriteLine(i);
				}
				else
				{
					Console.Write("{0} ", i);
				}
			}
		}
		return(number);
	}
}