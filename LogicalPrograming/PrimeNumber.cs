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

			Example: 3, 3, 5, 7, 11, 13, 17, 19....

			 */

			Console.Write("Enter a number: ");
			var inputNumber = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"Prime number between 2 and {inputNumber} are: ");
			bool isPrime = true;
			//outer for loop responsible for checking max number
			for (int i = 2; i <= inputNumber; i++)
			{
				//inner for loop responsible for checking factor
				for (int j = 2; j <= inputNumber; j++)
				{
					if (i != j && i % j == 0)
					{
						isPrime = false;
						break;
					}
				}
				if (isPrime)
				{
					Console.Write(i + " ");
				}
				isPrime = true;
			}

			Console.ReadLine();
		}
	}
}
