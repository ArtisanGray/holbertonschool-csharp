using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
	public static int Sum(LinkedList<int> myLList)
	{
		int sum = 0, i = 0;

		foreach (int item in myLList)
		{
			sum = sum + myLList.ElementAt(i);
			i++;
		}
		return (sum);
	}
}
