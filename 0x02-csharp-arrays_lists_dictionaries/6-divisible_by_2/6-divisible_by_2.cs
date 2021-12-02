using System;
using System.Collections.Generic;

class List
{
	public static List<bool> DivisibleBy2(List<int> myList)
	{
		List<bool> isTwo = new List<bool>();

		foreach (int item in myList)
		{
			if (item % 2 == 0)
				isTwo.Add(true);
			else
				isTwo.Add(false);
		}
		return (isTwo);
	}
}
