using System;

namespace Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Arrays";

			// create an array of strings
			string[] cars = new string[3]{"BMW", "Ford", "Opel"};

			// create an array of ints
			int[,] coords = new int[2,3]{ {1, 2, 3}, {4, 5, 6} };

			// output the second string
			// outputs the ints at the coords X1,Y1 and X2,Y3
			Console.WriteLine("Second Car: " + cars[1]);
			Console.WriteLine("X1, Y1: " + coords[0, 0]);
			Console.WriteLine("X2, Y3: " + coords[1, 2]);
			Console.ReadKey();
		}
	}
}
