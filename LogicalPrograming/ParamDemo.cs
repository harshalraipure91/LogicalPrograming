using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class ParamDemo
	{

		// "Param" keyword which can take variable number of argument
		// Param parameter must be single dimensional array
		// Params parameter must be the last parameter in a parameter list
		static void Main(string[] args)
		{
			int y = Add(5, 10, 15, 32, 56, 50);

            Console.WriteLine(y);
        }

		public static int Add(params int[] numbers)
		{
			int total = 0;

			foreach (var item in numbers)
			{
				total += item;
			}
			return total;
		}
		
	}
}
