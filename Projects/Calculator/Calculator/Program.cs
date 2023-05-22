using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			Menu();
		}

		static void Menu()
		{
			Console.Clear();

			Console.WriteLine("What calcule do you wanna make? ");
			Console.WriteLine("-------------------------------");
			Console.WriteLine("Write + for Sum");
			Console.WriteLine("Write - for Subtration");
			Console.WriteLine("Write / for Division");
			Console.WriteLine("Write * for Multiplies");
			Console.WriteLine("Write < for Exit");

			char calculationType = char.Parse(Console.ReadLine());

			if (calculationType == '<')
			{
				System.Environment.Exit(0);
			}
			else
			{
				Console.WriteLine("First value: ");
				double value1 = double.Parse(Console.ReadLine());

				Console.WriteLine("Second value: ");
				double value2 = double.Parse(Console.ReadLine());


				switch (calculationType)
				{
					case '+':
						Sum(value1, value2);
						break;

					case '-':
						Subtract(value1, value2);
						break;

					case '/':
						Divide(value1, value2);
						break;


					case '*':
						Multiplies(value1, value2);
						break;

					case '<':
						break;

					default:
						Console.WriteLine("This type of count doesn't exists!");
						break;
				}
			}
		}

		static void Sum(double value1, double value2)
		{
			double sum = value1 + value2;

			Console.WriteLine("The sum result is " + sum);
			Console.WriteLine("-------------------------------");
			Console.ReadKey();

			Menu();
		} 

		static void Subtract(double value1, double value2)
		{
			double subtraction = value1 - value2;

			Console.WriteLine("The subtraction result is " + subtraction);
			Console.WriteLine("-------------------------------");
			Console.ReadKey();

			Menu();
		}

		static void Divide(double value1, double value2)
		{
			double division = value1 / value2;

			Console.WriteLine("The division result is " + division);
			Console.WriteLine("-------------------------------");
			Console.ReadKey();

			Menu();
		}

		static void Multiplies(double value1, double value2)
		{
			double multiplication = value1 * value2;

			Console.WriteLine("The multiplication result is " + multiplication);
			Console.WriteLine("-------------------------------");
			Console.ReadKey();

			Menu();
		}
	}
}