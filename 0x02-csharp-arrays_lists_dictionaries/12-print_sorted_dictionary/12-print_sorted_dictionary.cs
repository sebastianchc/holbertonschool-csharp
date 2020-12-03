using System;
using System.Collections.Generic;

class Dictionary
{
	public static void PrintSorted(Dictionary<string, string> myDict)
	{
		List<string> DictKeys = new List<string>();
		foreach (var i in myDict.Keys)
		{
			DictKeys.Add(i);
		}
		DictKeys.Sort();
		foreach (var i in DictKeys)
		{
			Console.WriteLine("{0}: {1}", i, myDict[i]);
		}
	}
}