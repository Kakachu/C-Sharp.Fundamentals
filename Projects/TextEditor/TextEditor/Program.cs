using System;

namespace TextEditor
{
	class Program
	{
		static void Main(string[] args)
		{

		}

		static void Menu()
		{
			Console.WriteLine("What do you want to do?");
			Console.WriteLine("Type 1 for Open file");
			Console.WriteLine("Type 2 for Create new file");
			Console.WriteLine("Type 0 for Exit");

			short option = short.Parse(Console.ReadLine());
		}
	}
}