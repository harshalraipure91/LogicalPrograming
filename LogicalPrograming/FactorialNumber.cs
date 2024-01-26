using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class FactorialNumber
	{
		static void Main(string[] args)
		{
			Console.Write("Enter a number: ");
			var number = Convert.ToInt32(Console.ReadLine());
			int fact = 1;

			for (int i = 1; i <= number; i++)
			{
				fact *= i;
			}
			Console.WriteLine($"factorial of given number {number} is: {fact}");

			Console.ReadLine();
		}
	}
}
