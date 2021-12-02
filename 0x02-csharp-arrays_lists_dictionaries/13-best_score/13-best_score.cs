using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
	public static string BestScore(Dictionary<string, int> myList)
	{
		List<int> bigScore = myList.Values.ToList();
		bigScore.Sort();
		foreach (KeyValuePair<string, int> item in myList)
		{
			if (item.Value == bigScore[bigScore.Count - 1])
				return (item.Key);
		}
		return null;
	}
}
