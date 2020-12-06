using System;
using System.Collections.Generic;

class List
{
	public static List<int> DifferentElements(List<int> list1, List<int> list2)
	{
		List<int> difntList = new List<int>();
		foreach (int i in list1)
		{
			if (!list2.Contains(i))
			{
				difntList.Add(i);
			}
		}
		foreach (int j in list2)
		{
			if (!list1.Contains(j))
			{
				difntList.Add(j);
			}
		}
		difntList.Sort();
		return difntList;
	}
}