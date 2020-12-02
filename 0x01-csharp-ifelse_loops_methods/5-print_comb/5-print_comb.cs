using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i < 100; i++)
	    	if (i == 99)
	    	   Console.WriteLine(i);
		else
		   Console.Write("{0:D2}, ", i);
        }
    }
}
