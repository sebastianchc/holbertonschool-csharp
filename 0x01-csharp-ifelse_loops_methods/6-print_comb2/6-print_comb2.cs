using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
	    int j;
            for (i = 0; i < 9; i++)
	    	for (j = 1; j < 10; j++)
		    if (j > i)
		       if (i == 8 && j == 9)
		       	  Console.WriteLine("{0}{1}", i, j);
		       else
			  Console.Write("{0}{1}, ", i, j);
        }
    }
}
