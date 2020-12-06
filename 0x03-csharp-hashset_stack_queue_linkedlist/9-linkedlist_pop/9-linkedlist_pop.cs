using System;
using System.Collections.Generic;

class LList
{
	public static int Pop(LinkedList<int> myLList)
	{
		int n = 0;
		if (myLList.First == null)
		{
			return n;
		}
		n = myLList.First.Value;
		myLList.RemoveFirst();
		return n;
	}
}