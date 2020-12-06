using System;
using System.Collections.Generic;

class MyQueue
{
	public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
	{
		string ward;
		Console.WriteLine("Number of items: {0}", aQueue.Count);
		if (aQueue.Count == 0)
		{
			Console.WriteLine("Queue is empty");
		}
		else
		{
			Console.WriteLine("First item: {0}", aQueue.Peek());
		}
		aQueue.Enqueue(newItem);
		if (aQueue.Contains(search))
		{
			Console.WriteLine("Queue contains \"{0}\": True", search);
			while (aQueue.Count > 0)
			{
				ward = aQueue.Peek();
				aQueue.Dequeue();
				if (ward == search)
				{
					break;
				}
			}
		}
		else
		{
			Console.WriteLine("Queue contains \"{0}\": False", search);
		}
		return aQueue;
	}
}