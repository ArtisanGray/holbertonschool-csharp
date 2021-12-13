using System;
using System.Collections.Generic;
using System.Linq;

class Int
{
	public static void divide(int a, int b)
	{
		int x = 0;

		try
		{
			x = a / b;
		}
		catch (DivideByZeroException)
		{
			Console.WriteLine("Cannot divide by zero");
			x = 0;
		}
		finally
		{
			Console.WriteLine("{0} / {1} = {2}", a.ToString(), b.ToString(), x.ToString());
		}
	}
}
