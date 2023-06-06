using System;

namespace _Exception
{
	class Program
	{
		static void Main(string[] args)
		{
			var arr = new int[3];

			try
			{
				//for (int i = 0; i < 10; i++)
				//{
				//	Console.WriteLine(arr[i]);
				//}
				var text = Console.ReadLine();
				Register(text);
			}
			catch (IndexOutOfRangeException ex)
			{
				Console.WriteLine(ex.InnerException);
				Console.WriteLine(ex.Message);
				Console.WriteLine("Index not found!");
			}
			catch(ArgumentNullException ex)
			{
				Console.WriteLine(ex.InnerException);
				Console.WriteLine(ex.Message);
				Console.WriteLine("Failed to register text");
			}
			catch (CustomException ex)
			{
				Console.WriteLine(ex.InnerException);
				Console.WriteLine(ex.Message);
				Console.WriteLine(ex.TimeOccurrence);
				Console.WriteLine("Custom Exception");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Uops, something went wrong!");
			}
			finally
			{
				Console.WriteLine("Reached in the end");
			}
		}

		static void Register(string text)
		{
			if (string.IsNullOrEmpty(text))
				Console.WriteLine("Text cannot be Null or Empty");
		}

        public class CustomException : Exception
		{
			public CustomException(DateTime date)
			{
				TimeOccurrence = date;
			}
			
			public DateTime TimeOccurrence { get; set; }
        }
	}
}