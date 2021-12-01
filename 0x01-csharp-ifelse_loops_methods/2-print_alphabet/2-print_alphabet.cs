using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
		string alpha = "abcdefghijklmnopqrstuvwxyz";
		foreach (char letter in alpha)
			Console.Write(letter);
        }
    }
}
