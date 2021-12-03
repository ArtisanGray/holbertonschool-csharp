using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
	public static LinkedList<int> CreatePrint(int size)
	{
		int i;
		LinkedList<int> newList = new LinkedList<int>();
		if (size > 0)
		{
			for (i = 0; i < size; i++)
				newList.AddLast(i);
			foreach (int item in newList)
				Console.WriteLine(item);
		}
		return (newList);
	}
}
