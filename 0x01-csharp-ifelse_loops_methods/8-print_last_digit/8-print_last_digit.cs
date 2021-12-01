using System;

class Number
{
        public static int PrintLastDigit(int number)
        {
		int last_digit = number % 10;
		if (number < 0)
			last_digit = last_digit * -1;
		Console.Write(last_digit.ToString());
		return (last_digit);
        }
}
