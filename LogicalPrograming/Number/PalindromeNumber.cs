using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class PalindromeNumber
	{
		static void Main(string[] args)
		{
			Console.Write("Enter a number: ");
			var number = Convert.ToInt32(Console.ReadLine());
			var result = 0;
			var temp = number;
			while (number > 0)
			{
				var rem = number % 10;
				result = result * 10 + rem;
				number /= 10;
			}
			number = temp;

			if (number == result)
			{
				Console.WriteLine($"Given Number {number} is palindrome number");
			}
			else
			{
				Console.WriteLine($"Given Number {number} not palindrome number");
			}
			Console.ReadLine();
		}
	}
}
