using System;

namespace Conversion
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Conversion";

			// Convert.ToInt32():   A 32-bit signed integer
			// Convert.ToDouble():  A floating-point precision number
			// Convert.ToDecimal(): A decimal precision number

			Console.Write("Please Enter A Number: ");
			double num = Convert.ToDouble(Console.ReadLine());
			Console.Write("Now Enter Another Number: ");
			double sum = num + Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Total = " + sum);
			Console.ReadKey();
		}
	}
}
