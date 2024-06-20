using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class FindSubstringCountInString
	{
		static void Main(string[] args)
		{
			#region Method1

			//var input = "This is a test message";
			//int count = 0;
			//var subString = "is";
			//var index = input.ToLower().IndexOf(subString);

			//while (index > 0 || index != -1)
			//{
			//	count++;
			//	index = input.ToLower().IndexOf(subString, index + 1);
			//}
			//Console.WriteLine($"No of count of '{subString}' is: {count}");

			#endregion

			#region Method2

			var input = "This is a test message";
			int count = 0;
			var subString = "is";
			var splitInput = input.ToLower().Split(' ');
			for (int i = 0; i < splitInput.Length; i++)
			{
				if (splitInput[i].Contains(subString))
				{
					count++;
				}
			}
			Console.WriteLine($"No of count of '{subString}' is: {count}");

			#endregion

			Console.ReadLine();

		}
	}
}
