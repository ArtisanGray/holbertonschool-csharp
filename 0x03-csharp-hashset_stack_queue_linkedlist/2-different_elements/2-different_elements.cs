using System;
using System.Collections.Generic;

class List
{
	public static List<int> DifferentElements(List<int> list1, List<int> list2)
	{
		List<int> diffList = new List<int>();

		foreach (int item in list1)
		{
			if (!list2.Contains(item))
				diffList.Add(item);
		}
		foreach (int item in list2)
		{
			if (!list1.Contains(item))
				diffList.Add(item);
		}
		diffList.Sort();
		return (diffList);
	}
}
