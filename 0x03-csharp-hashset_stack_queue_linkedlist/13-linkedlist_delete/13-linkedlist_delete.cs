using System;
using System.Collections.Generic;

class LList
{
	public static void Delete(LinkedList<int> myLList, int index)
	{
		int idx = 0;
		LinkedListNode<int> current = myLList.First;
		if (index < 0 || index >= myLList.Count)
		{
			return;
		}
		while (current != null)
		{
			if (idx == index)
			{
				myLList.Remove(current);
				return;
			}
			current = current.Next;
			idx++;
		}
	}
}