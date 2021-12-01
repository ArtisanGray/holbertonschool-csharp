using System;

class Character
{
        public static bool IsLower(char c)
        {
        	string up = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

		if (Char.IsLetter(c) == false)
			return false;
		foreach (char letter in up)
		{
			if (letter == c)
				return false;
		}
		return true;
        }
}
