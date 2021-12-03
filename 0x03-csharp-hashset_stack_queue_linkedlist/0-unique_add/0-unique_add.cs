using System;
using System.Collections.Generic;
using System.Linq;

class List
{
	public static int Sum(List<int> myList)
	{
		List<int> uList = myList.Distinct().ToList();
		int sum = 0;

		foreach (int item in uList)
		{
			sum += item;
		}
		return sum;
	}
}
