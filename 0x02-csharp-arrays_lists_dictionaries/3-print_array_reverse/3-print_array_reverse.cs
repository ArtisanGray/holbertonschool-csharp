using System;

class Array
{
	public static void Reverse(int[] array)
	{
		if (array != null)
		{
			int i, j, k;
			int[] reverse_array = new int[array.Length];

			for (i = array.Length - 1, j = 0; i >= 0; i--, j++)
			{
				reverse_array[j] = array[i];
			}
			for (k = 0; k < reverse_array.Length; k++)
			{
				Console.Write(reverse_array[k]);
				if (k < reverse_array.Length - 1)
				Console.Write(" ");
			}
		}
		Console.WriteLine();
	}
}
