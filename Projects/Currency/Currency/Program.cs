using System;
using System.Globalization;

namespace Currency
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal value = 10.25m;
			Console.WriteLine("Round - Rounds to nearest value " + Math.Round(value));
			Console.WriteLine("Ceiling - Rounds to upper value " + Math.Ceiling(value));
			Console.WriteLine("Floor - Rounds to lower value " + Math.Floor(value));
		}
	}
}