using System;
using System.Collections.Generic;

class LList
{
	public static int Length(LinkedList<int> myLList)
	{
		int n = 0;
		foreach (int i in myLList)
		{
			n++;
		}
		return n;
	}
}