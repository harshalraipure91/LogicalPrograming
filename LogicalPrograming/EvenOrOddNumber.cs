using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class EvenOrOddNumber
	{
		static void Main(string[] args)
		{
			Console.Write("Enter a number: ");
			var inputNumber = Convert.ToInt32(Console.ReadLine());

			if (inputNumber % 2 == 0)
			{
                Console.WriteLine($"The given number {inputNumber} is even number");
            }
			else
			{
				Console.WriteLine($"The given number {inputNumber} is odd number");
			}

			Console.ReadLine();
		}
	}
}
