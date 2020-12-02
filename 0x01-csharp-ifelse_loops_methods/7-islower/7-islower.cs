using System;

class Character
{
	public static bool IsLower(char c)
	{
		if (c > 64 && c < 91)
		   	return(false);
		else
			return(true);
	}
}