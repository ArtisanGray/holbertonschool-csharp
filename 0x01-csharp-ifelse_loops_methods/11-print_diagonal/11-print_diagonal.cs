using System;

class Line
{
	public static void PrintDiagonal(int length)
	{
		int i, j;

		if (length > 0)
		{
			for (i = 0; i < length; i++)
			{
				for (j = 0; j <= i; j++)
				{
					if (j == i)
						Console.Write("\\");
					else
						Console.Write(" ");
				}
				Console.Write("\n");
			}
		}
		else
			Console.Write("\n");
	}
}
