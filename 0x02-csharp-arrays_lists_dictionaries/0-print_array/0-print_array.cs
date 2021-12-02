using System;

class Array
{
	public static int[] CreatePrint(int size)
	{
		int i, j;

		if (size < 0)
		{
			Console.WriteLine("Size cannot be negative");
			return null;
		}
		int[] array = new int[size];

		for (i = 0; i < size; i++)
		{
			array[i] = i;
		}
		if (size > 0)
		{
			for (j = 0; j < array.Length; j++)
			{
				Console.Write(array[j]);
				if (j < array.Length - 1)
					Console.Write(" ");
			}
		}
		Console.WriteLine();
		return (array);
	}
}
