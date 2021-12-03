using System;
using System.Collections.Generic;
using System.Linq;

class MyQueue
{
	public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
	{
		Console.WriteLine("Number of items: {0}", aQueue.Count);
		if (aQueue.Count != 0)
			Console.WriteLine("Top item: {0}", aQueue.Peek());
		else
			Console.WriteLine("Queue is empty");

		if (aQueue.Contains(search) == true)
		{
			Console.WriteLine("Queue contains \"{0}\": True", search);
			while (aQueue.Count != 0)
			{
				string tmp = aQueue.Peek();
				aQueue.Dequeue();
				if (tmp == search)
					break;
			}
		}
		else
			Console.WriteLine("Queue contains \"{0}\": False", search);

		aQueue.Enqueue(newItem);
		return (aQueue);
	}
}
