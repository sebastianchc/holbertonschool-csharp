using System;
using System.Collections.Generic;

class List
{
	public static int Sum(List<int> myList)
	{
		int sum = 0;
		for (int i = 0; i < myList.Count; i++)
		{
			for (int j = i + 1; j < myList.Count; j++)
			{
				if (myList[i] == myList[j])
				{
					myList.Remove(myList[j]);
				}
			}
			sum = sum + myList[i];
		}
		return sum;
	}
}