using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
	public static int FindNode(LinkedList<int> myLList, int value)
	{
		int indexCount = 0;
		foreach (int item in myLList)
		{
			if (value == item)
				return (indexCount);
			indexCount++;
		}
		return (-1);
	}
}
