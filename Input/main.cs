using System;

namespace Input
{
	class Program
	{
		static void Main(string[] args)
		{
			//name console window
			Console.Title = "Input";

			// Get input from the user and store it in string name
			Console.Write("Please Enter Your Name: ");
			string name = Console.ReadLine();

			// write message containing user input
			Console.WriteLine("Welcome " + name + "!");
			Console.ReadKey();
		}
	}
}
