using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
        	string alpha = "abcdefghijklmnopqrstuvwxyz";
		foreach (char letter in alpha)
		{
			if (letter != 'e' && letter != 'q')
				Console.Write(letter);
		}
        }
    }
}
