using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class ArmStrongNumber
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
				var cube = rem * rem * rem;
				result += cube;
				number /= 10;
			}
			number = temp;
			if (number == result)
			{
				Console.WriteLine($"Given number {number} is armstrong number");
			}
			else
			{
				Console.WriteLine($"Given number {number} is not armstrong number");
			}

			Console.ReadLine();
		}
	}
}
