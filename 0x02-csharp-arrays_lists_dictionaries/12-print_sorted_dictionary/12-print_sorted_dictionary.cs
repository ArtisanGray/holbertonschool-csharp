using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
	public static void PrintSorted(Dictionary<string, string> myDict)
	{
		List<string> sortedList = myDict.Keys.ToList();
		sortedList.Sort();

		foreach (string key in sortedList)
		{
			Console.WriteLine("{0}: {1}", key, myDict[key]);
		}
	}
}
