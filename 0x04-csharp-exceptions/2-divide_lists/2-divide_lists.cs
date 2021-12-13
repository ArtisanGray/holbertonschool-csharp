using System;
using System.Collections.Generic;
using System.Linq;

class List
{
	public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
	{
		int i = 0, j = 0, div = 0, k = 0;
		List<int> divResults = new List<int>();

		for (; i < listLength; i++)
		{
			try
			{
				j = list1[i];
				k = list2[i];
			}
			catch (ArgumentOutOfRangeException)
			{
				Console.WriteLine("Out of range");
				return (divResults);
			}
			try
			{
				div = list1[i] / list2[i];
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("Cannot divide by zero");
			}
			divResults.Add(div);
			div = 0;
		}
		return (divResults);
	}
}
