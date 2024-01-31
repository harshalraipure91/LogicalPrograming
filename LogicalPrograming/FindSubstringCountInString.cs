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

			var input = "This is a test message";
			int count = 0;
			var subString = "is";
			var index = input.ToLower().IndexOf(subString);

			while (index > 0)
			{
				count++;
				index = input.ToLower().IndexOf(subString, index + 1);
			}
			Console.WriteLine($"No of count of {subString}' is: {count}");



			Console.ReadLine();

		}
	}
}
