using System;
using System.Collections.Generic;

class Dictionary
{
	public static int NumberOfKeys(Dictionary<string, string> myDict)
	{
		int num = 0;
		foreach (var i in myDict)
		{
			num++;
		}
		return(num);
	}
}