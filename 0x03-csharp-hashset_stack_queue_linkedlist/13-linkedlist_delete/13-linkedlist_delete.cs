using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
	public static void Delete(LinkedList<int> myLList, int index)
	{
		int i = 0;
		if (index >= 0 && index < myLList.Count)
		{
			foreach (int item in myLList)
			{
				if (i == index)
				{
					myLList.Remove(myLList.Find(item));
					break;
				}
				i++;
			}
		}
	}
}
