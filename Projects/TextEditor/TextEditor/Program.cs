using System;

namespace TextEditor
{
	class Program
	{
		static void Main(string[] args)
		{
			Menu();
		}

		static void Menu()
		{
			Console.WriteLine("What do you want to do?");
			Console.WriteLine("Type 1 for Open file");
			Console.WriteLine("Type 2 for Create new file");
			Console.WriteLine("Type 0 for Exit");

			short option = short.Parse(Console.ReadLine());

			switch (option)
			{
				case 0: System.Environment.Exit(0);
					break;
				case 1: OpenFile();
					break;
				case 2: EditFile();
					break;
				default: Menu();
					break;
			}
		}

		static void OpenFile()
		{
			Console.Clear();
			Console.WriteLine("What is the path?");
			string path = Console.ReadLine();

			using (var file = new StreamReader(path))
			{
				string text = file.ReadToEnd();
				Console.WriteLine("--------------------");
				Console.WriteLine(text);
			}

			Console.WriteLine("");
			Console.ReadLine();
			Console.Clear();

			Menu();
		}

		static void EditFile()
		{
			string text = "";

			Console.Clear();
			Console.WriteLine("Type your text below (press 'ESC' to exit)");
			Console.WriteLine("--------------------");
			do
			{
				text += Console.ReadLine();
				text += Environment.NewLine;
			}
			while (Console.ReadKey().Key != ConsoleKey.Escape);

			Save(text);
		}

		static void Save(string text)
		{
			Console.Clear();
			Console.WriteLine("What is the path?");
			var path = Console.ReadLine();

			using (var file = new StreamWriter(path))
			{
				file.Write(text);
			}

			Console.WriteLine($"The file {path} has been saved with sucessfully");
			Console.ReadLine();
			Console.Clear();

			Menu();
		}
	}
}