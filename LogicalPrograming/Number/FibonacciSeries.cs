using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class FibonacciSeries
	{
		static void Main(string[] args)
		{
			#region Fibonacci Series defination and example

			/*
					It is a series of number in which each number is the sum of the two preceding number

			Example:
			0, 1, 1, 2, 3, 5, 8...

			 */
			#endregion

			#region method1

			//int number, previousNumber = -1, nextNumber = 1;

			//Console.WriteLine("Please enter the number which you would like Fibonacci series");
			//number = Convert.ToInt32(Console.ReadLine());

			//Console.WriteLine("Fibonacci series ");

			//for (int i = 0; i < number; i++)
			//{
			//	int sumNumber = previousNumber + nextNumber;
			//	Console.Write(sumNumber + " ");
			//	previousNumber = nextNumber;
			//	nextNumber = sumNumber;
			//}

			#endregion

			#region Method2
			int a = 0;
			int b = 1;
			Console.Write("please enter the number which you would like Fibonacci series: ");
			var number = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(a);
			Console.WriteLine(b);

			for (int i = 0; i < number; i++)
			{
				var c = a + b;
				Console.WriteLine(c);
				a = b;
				b = c;
			}
			#endregion

			Console.ReadLine();
		}
	}
}
