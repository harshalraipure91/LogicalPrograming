using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class SumOfNumber
	{
		static void Main(string[] args)
		{
			int sumOfNumber = 0;
			Console.Write("Enter a number you want to find a sum: ");

			var userInput = Convert.ToInt32(Console.ReadLine());

			while (userInput > 0)
			{
				var rem = userInput % 10;
				userInput /= 10;
				sumOfNumber += rem;
			}
            Console.WriteLine($"Sum of given number is {sumOfNumber}");

            Console.ReadLine();
		}
	}
}
