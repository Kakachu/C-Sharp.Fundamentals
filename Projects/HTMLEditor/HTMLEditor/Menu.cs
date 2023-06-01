using System;

namespace HTMLEditor
{
	public static class Menu
	{
		const int lineSize = 30;

		public static void Show()
		{
			Console.Clear();
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.ForegroundColor = ConsoleColor.Magenta;

			DrawScreen();
			ShowOptions();

			Console.SetCursorPosition(3, 11);
			var option = int.Parse(Console.ReadLine());
			HandleMenuOption(option);
		}

		public static void DrawScreen() 
		{
			DrawLines();
			DrawColumns();
			DrawLines();
		}

		static void DrawLines()
		{
			Console.Write("+");
			for (int i = 0; i <= lineSize; i++)
				Console.Write("-");

			Console.Write("+");
			Console.Write("\n");
		}

		static void DrawColumns()
		{
			for (int lines = 0; lines <= 10; lines++)
			{
				Console.Write("|");

				for (int i = 0; i <= lineSize; i++)
					Console.Write(" ");

				Console.Write("|");
				Console.Write("\n");
			}
		}

		static void ShowOptions()
		{
			Console.SetCursorPosition(3, 2);
			Console.WriteLine("HtmlEditor");
			Console.SetCursorPosition(3, 3);
			Console.WriteLine("================");

			Console.SetCursorPosition(3, 4);
			Console.WriteLine("Select an option below:");

			Console.SetCursorPosition(3, 6);
			Console.WriteLine("Type 1 - To create a new file");

			Console.SetCursorPosition(3, 7);
			Console.WriteLine("Type 2 - To open file");

			Console.SetCursorPosition(3, 9);
			Console.WriteLine("Type 0 - To exit");
		}
		
		public static void HandleMenuOption(int option)
		{
			switch (option)
			{
				case 1: Edit.Show(false); 
					break;
				case 2: Edit.Show(true);
					break;
				case 0:
					{
						Console.Clear();
						System.Environment.Exit(0);
						break;
					}
				default: Show();
					break;
			}
		}
	}
}
