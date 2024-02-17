using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class CountNoOfDigitsInNumber
	{
		static void Main(string[] args)
		{
			Console.Write("Enter a number: ");
			var number = Convert.ToInt32(Console.ReadLine());
			var count = 0;
			var temp = number;
			while (number > 0)
			{
				count++;
				number /= 10;
			}
			number = temp;
			Console.WriteLine($"Total digits in a number {number} is: {count}");
		}
	}
}
