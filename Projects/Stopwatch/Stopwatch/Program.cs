using System;

namespace Stopwatch
{
	class Program
	{
		static void Main(string[] args)
		{
			Menu();
		}

		static void Menu()
		{
			Console.WriteLine("Type 'm' for minutes or 's' for seconds");
			Console.WriteLine("Write the time you want to count");

			string data = Console.ReadLine().ToLower();

			char type = char.Parse(data.Substring(data.Length - 1, 1));
			int time = int.Parse(data.Substring(0, data.Length - 1));
			int multiplier = 1;

			if (type == 'm')
				multiplier = 60;

			if((type != 'm') || (type != 's'))


			if(time == 0)
				System.Environment.Exit(0);

			PreStart(time * multiplier);
		}

		static void PreStart(int time)
		{
			Console.Clear();

			Console.WriteLine("Are you ready?....");
			Thread.Sleep(2000);

			Console.WriteLine("3...");
			Thread.Sleep(1000);

			Console.WriteLine("2..");
			Thread.Sleep(1000);

			Console.WriteLine("1.");
			Thread.Sleep(1000);

			Console.WriteLine("GO!");
			Thread.Sleep(100);

			Start(time);
		}

		static void Start(int time)
		{
			int currentTime = 0;

			while (currentTime != time)
			{
				Console.Clear();
				currentTime++;
				Console.WriteLine(currentTime);
				Thread.Sleep(1000);
			}

			Console.Clear();
			Console.WriteLine("Stopwatch ended");
			Console.WriteLine("----------------------------");
			Console.ReadKey();
			Console.Clear();

			Menu();
		}
	}
}
