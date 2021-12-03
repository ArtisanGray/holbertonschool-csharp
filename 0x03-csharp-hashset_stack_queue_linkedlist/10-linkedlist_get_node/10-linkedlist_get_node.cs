using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
	public static int GetNode(LinkedList<int> myLList, int n)
	{
		int i = 0;
		if (n >= 0 && n < myLList.Count)
		{
 			foreach (int item in myLList)
			{
				if (i == n)
					break;
				i++;
			}
			return (myLList.ElementAt(i));
		}
		return 0;
	}
}
