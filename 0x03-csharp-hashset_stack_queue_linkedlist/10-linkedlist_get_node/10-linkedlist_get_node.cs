using System;
using System.Collections.Generic;

class LList
{
	public static int GetNode(LinkedList<int> myLList, int n)
	{
		int idx = 0;
		if (n >= myLList.Count)
		{
			return 0;
		}
		else
		{
			foreach (int i in myLList)
			{
				if (idx == n)
				{
					idx = i;
					break;
				}
				idx++;
			}
			return idx;
		}
	}
}