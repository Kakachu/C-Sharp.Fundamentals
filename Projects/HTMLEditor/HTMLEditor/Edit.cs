using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLEditor
{
	public class Edit
	{
		public static void Show(bool isUpload)
		{
			Console.Clear();
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Clear();
			Console.WriteLine("EDIT MODE");
			Console.WriteLine("--------------");
			Console.WriteLine(" Type 'ESC' - To Exit");
			Console.WriteLine("---------------");
			Start(isUpload);
		}

		public static void Start(bool isUpload)
		{
			if (isUpload)
			{
				string file;

				Console.WriteLine(" Write the path right here:");
				var path = Console.ReadLine();

				using (StreamReader streamReader = new StreamReader(path))
				{
					file = streamReader.ReadToEnd();
					streamReader.Close();
				}

				Console.WriteLine("---------------");
				Viewer.Show(file);
			}
			else
			{
				var file = new StringBuilder();

				do
				{
					file.Append(Console.ReadLine());
					file.Append(Environment.NewLine);
				} while (Console.ReadKey().Key != ConsoleKey.Escape);

				Console.WriteLine("---------------");
				Viewer.Show(file.ToString());
			}
		}
	}
}
