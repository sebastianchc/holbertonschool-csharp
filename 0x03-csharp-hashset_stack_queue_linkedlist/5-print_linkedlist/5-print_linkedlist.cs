using System;
using System.Collections.Generic;

class LList
{
	public static LinkedList<int> CreatePrint(int size)
	{
		int i = 0;
		LinkedList<int> newList = new LinkedList<int>();
		while (i < size)
		{
			newList.AddLast(i);
			Console.WriteLine(i);
			i++;
		}
		return newList;
	}
}