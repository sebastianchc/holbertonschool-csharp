using System;
using System.Collections.Generic;

class List
{
	public static int Sum(List<int> myList)
	{
		int sum = 0;
		HashSet<int> listUnique = new HashSet<int>(myList);
		foreach (int num in listUnique)
		{
			sum = sum + num;
		}
		return sum;
	}
}