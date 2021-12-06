using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
	public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
	{
		int i = 0;
		LinkedListNode<int> newNode = new LinkedListNode<int>(n);
		foreach (int item in myLList)
		{
			if (item > n)
			{
				myLList.AddBefore(myLList.Find(item), n);
				break;
			}
			else if (n > item && item == myLList.Last.Value)
			{
				myLList.AddAfter(myLList.Find(item), n);
				break;
			}
			i++;
		}
		return (newNode);
	}
}
