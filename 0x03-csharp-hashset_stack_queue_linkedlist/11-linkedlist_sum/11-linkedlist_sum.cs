using System;
using System.Collections.Generic;

class LList
{
	public static int Sum(LinkedList<int> myLList)
	{
		int sum = 0;
		foreach (int i in myLList)
		{
			sum = sum + i;
		}
		return sum;
	}
}