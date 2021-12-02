using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
		int [,] rectangle = new int[5, 5] { {0, 0, 0, 0, 0},{0, 0, 0, 0, 0},{0, 0, 1, 0, 0},{0, 0, 0, 0, 0},{0, 0, 0, 0, 0} };
		int i, j;

		for (i = 0; i < rectangle.GetLength(0); i++)
		{
			for (j = 0; j < rectangle.GetLength(1); j++)
			{
				Console.Write(rectangle[i,j]);
				if (j < rectangle.GetLength(1) - 1)
					Console.Write(" ");
			}
			Console.WriteLine();
		}
        }
    }
}
