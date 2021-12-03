using System;
using System.Collections.Generic;
using System.Linq;

class MyStack
{
	static void stackSearch(Stack<string> sStack, string search, int found)
	{
		if (sStack.Count == 0)
			return;
		string plate = sStack.Peek();

		sStack.Pop();
		if (plate == search)
			stackSearch(sStack, search, found + 1);
		else
			stackSearch(sStack, search, found);
		if (found == 1)
		{
			sStack.Push(plate);
		}
	}
	public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
	{

		Console.WriteLine("Number of items: {0}", aStack.Count);
		if (aStack.Count != 0)
			Console.WriteLine("Top item: {0}", aStack.Peek());
		else
			Console.WriteLine("Stack is empty");

		if (aStack.Contains(search) == true)
		{
			Console.WriteLine("Stack contains \"{0}\": True", search);
			stackSearch(aStack, search, 0);
		}
		else
			Console.WriteLine("Stack contains \"{0}\": False", search);

		aStack.Push(newItem);
		return (aStack);
	}
}
