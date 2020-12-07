using System;
using System.Collections.Generic;

class Dictionary
{
	public static string BestScore(Dictionary<string, int> myList)
	{
		int maxScore = 0;
		string player = null;
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