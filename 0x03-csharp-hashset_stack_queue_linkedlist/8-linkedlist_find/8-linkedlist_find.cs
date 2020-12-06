using System;
using System.Collections.Generic;

class LList
{
	public static int FindNode(LinkedList<int> myLList, int value)
	{
		int idx = 0;
		foreach (int i in myLList)
		{
			if (i == value)
			{
				return idx;
			}
			idx++;
		}
		return -1;
	}
}