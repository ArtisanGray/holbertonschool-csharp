using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
	public static int Pop(LinkedList<int> myLList)
	{
		int nodeValue = myLList.First.Value;
		if (myLList.Count == 0)
			return (0);
		myLList.Remove(myLList.First);
		return (nodeValue);
	}
}
