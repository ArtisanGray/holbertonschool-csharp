using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
	public static int Pop(LinkedList<int> myLList)
	{
		int nodeValue = myLList.First.Value;
		myLList.Remove(myLList.First);
		return (nodeValue);
	}
}
