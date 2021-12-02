using System;
using System.Collections.Generic;

class List
{
	public static List<int> CreatePrint(int size)
	{
		int i, j;
		if (size < 0)
		{
			Console.WriteLine("Size cannot be negative");
			return null;
		}
		List<int> int_list = new List<int>();

		for (i = 0; i < size; i++)
			int_list.Add(i);

		for (j = 0; j < int_list.Count; j++)
		{
			Console.Write(int_list[j]);
			if (j < int_list.Count - 1)
				Console.Write(" ");
		}
		Console.WriteLine();
		return (int_list);
	}
}
