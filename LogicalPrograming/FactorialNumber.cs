using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class FactorialNumber
	{
		#region Using For Loop
		//static void Main(string[] args)
		//{
		//	Console.Write("Enter a number: ");
		//	var number = Convert.ToInt32(Console.ReadLine());
		//	int fact = 1;

		//	for (int i = 1; i <= number; i++)
		//	{
		//		fact *= i;
		//	}
		//	Console.WriteLine($"factorial of given number {number} is: {fact}");

		//	Console.ReadLine();
		//}

		#endregion


		#region Using Recursive function
		static void Main(string[] args)
		{
			Console.Write("Enter a number: ");
			var number = Convert.ToInt32(Console.ReadLine());
			var output = GetFactorial(number);
            Console.WriteLine($"Factorial of number is: {output}");
        }


		private static int GetFactorial(int n)
		{
			var value = n >= 1 ? n * GetFactorial(n - 1) : 1;
			return value;
		}

		#endregion
	}
}
