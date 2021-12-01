using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
		int i;

		for (i = 1; i <= 100; i++)
		{
			if (i % 5 == 0)
			{
				if (i % 3 == 0)
					Console.Write("FizzBuzz");
				else
					Console.Write("Buzz");
			}
			else if (i % 3 == 0)
				Console.Write("Fizz");
			else
				Console.Write(i);
			if (i < 100)
				Console.Write(" ");
		}
		Console.Write("\n");
        }
    }
}
