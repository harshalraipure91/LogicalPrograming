using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class PrimeNumber
	{
		static void Main(string[] args)
		{
			/*
			 
			Prime Number = Those number which is divisible by 1 and by itself
			It has two factors, 1 and by itself

			Fact about prime number are:
			1. 0 and 1 are not consider as prime number.
			2. 2 is even prime number, It is smallest prime number

			Example: 2, 3, 5, 7, 11, 13, 17, 19....

			 */

			Console.Write("Enter a number: ");
			var inputNumber = Convert.ToInt32(Console.ReadLine());
			int count = 0;
			for (int i = 1; i <= inputNumber; i++)
			{
				if (inputNumber % i == 0)
				{
					count++;
				}
			}

			//if (count == 2)
			//{
			//	Console.WriteLine($"The given number {inputNumber} is a prime number.");
			//}
			//else
			//{
			//	Console.WriteLine($"The given number {inputNumber} is not a prime number.");
			//}

			Console.WriteLine(count == 2 ? "Prime Number" : "Not a Prime Number");

			Console.ReadLine();
		}
	}
}
