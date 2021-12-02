using System;
using System.Collections.Generic;

class List
{
	public static List<int> CreatePrint(int size)
	{
		int i;
		if (size < 0)
		{
			Console.WriteLine("Size cannot be negative");
			return null;
		}
		List<int> int_list = new List<int>();

		for (i = 0; i < size; i++)
			int_list.Add(i);
		return (int_list);
	}
}
