using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
		int i, j;

		for (i = 0; i < 10; i++)
		{
			for(j = i + 1; j < 10; j++)
			{
				Console.Write(i.ToString() + j.ToString());
				if (i == 8 && j == 9)
					break;
				Console.Write(", ");
			}
		}
		Console.WriteLine();
        }
    }
}
