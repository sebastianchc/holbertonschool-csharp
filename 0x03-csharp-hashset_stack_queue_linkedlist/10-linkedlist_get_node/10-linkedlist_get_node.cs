using System;
using System.Collections.Generic;

class LList
{
	public static int GetNode(LinkedList<int> myLList, int n)
	{
		int idx = 0;
		foreach (int i in myLList)
		{
			if (idx == n)
			{
				return i;;
			}
			idx++;
		}
		return 0;
	}
}