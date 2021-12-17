using System;

namespace MyMath
{
    public class Matrix
    {
        public static int[,] Divide(int[,] matrix, int num)
        {
            int i, j;
			int [,] divMatrix = matrix;

			if (matrix == null)
				return null;
			for (i = 0; i < matrix.GetLength(0); i++)
			{
				for (j = 0; j < matrix.GetLength(1); j++)
				{
					try
                    {
						divMatrix[i, j] = matrix[i, j] / num;
					}
					catch
                    {
						Console.WriteLine("Num cannot be 0");
						return null;
                    }
				}
			}
			return (divMatrix);
        }
    }
}
