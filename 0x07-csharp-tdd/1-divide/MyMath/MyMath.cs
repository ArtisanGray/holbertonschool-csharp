using System;

namespace MyMath
{
	/// <summary>
	/// divides members of a matrix.
	/// </summary>
    public class Matrix
    {
		/// <summary>
		/// takes a number and divides the members in the matrix. returns a new matrix.
		/// </summary>
		/// <param name="matrix">matrix from call</param>
		/// <param name="num">number to divide each member by</param>
		/// <returns>a new matrix, now full of the division results.</returns>
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
