using System;
using System.Collections.Generic;

class List
{
	public static List<int> CommonElements(List<int> list1, List<int> list2)
	{
		List<int> commonList = new List<int>();
		foreach (var i in list1)
		{
			if (list2.Contains(i))
			{
				commonList.Add(i);
			}
		}
		return commonList;
	}
}