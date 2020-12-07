using System;
using System.Collections.Generic;

class LList
{
	public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
	{
		LinkedListNode<int> newNode = new LinkedListNode<int>(n);
		LinkedListNode<int> headNode = myLList.First;
		if (headNode == null)
		{
			myLList.AddFirst(newNode);
			return newNode;
		}
		while (headNode != null)
		{
			if (headNode.Value > n)
			{
				myLList.AddBefore(headNode, newNode);
				return newNode;
			}
			headNode = headNode.Next;
		}
		myLList.AddLast(newNode);
		return newNode;
	}
}