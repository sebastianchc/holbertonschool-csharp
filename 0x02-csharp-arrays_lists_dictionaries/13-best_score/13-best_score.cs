using System;
using System.Collections.Generic;

class Dictionary
{
	public static string BestScore(Dictionary<string, int> myList)
	{
		int maxScore = 0;
		string player = null;
		if (myList.Count == 0)
		{
			return "None";
		}
		foreach (string i in myList.Keys)
		{
			if (myList[i] > maxScore)
			{
				maxScore = myList[i];
				player = i;
			}
		}
		return player;
	}
}