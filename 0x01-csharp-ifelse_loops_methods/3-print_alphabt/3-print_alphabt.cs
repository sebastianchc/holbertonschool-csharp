﻿using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            char i;
	    for (i = 'a'; i <= 'z'; i++)
	    	if (i != 'e' && i != 'q')
		   Console.Write(i);
        }
    }
}
