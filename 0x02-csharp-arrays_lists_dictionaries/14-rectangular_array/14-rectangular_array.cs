using System;
using System.Collections.Generic;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
		int[,] matrix = new int[5,5];
		for (int i = 0; i < 5; i++)
		{
			for (int j = 0; j < 5; j++)
			{
				if (i == 2 && j == 2)
				{
					matrix[i, j] = 1;
				}
				else
				{
					matrix[i, j] = 0;
				}
				if (j == 4)
				{
					Console.WriteLine("{0}", matrix[i, j]);
				}
				else
				{
					Console.Write("{0} ", matrix[i, j]);
				}
			}
		}
        }
    }
}
