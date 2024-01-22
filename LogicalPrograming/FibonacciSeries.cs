﻿using System;
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

			int number, previosNumber = -1, nextNumber = 1;

			Console.WriteLine("Please enter the number which you would like fibonacci series");
			number = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Fibonacci series ");

			for (int i = 0; i < number; i++)
			{
				int sumNumber = previosNumber + nextNumber;
				Console.Write(sumNumber + " ");
				previosNumber = nextNumber;
				nextNumber = sumNumber;
			}

			Console.ReadLine();
		}
	}
}