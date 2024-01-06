using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class Test
	{
		static void Main(string[] args)
		{
			// 2 5 10 17 26 37

			int input = 2; // The starting value
			int oddNumber = 1; // The first odd number to add
			

			for (int i = 0; i < 6; i++)
			{
				Console.WriteLine(input);
				oddNumber += 2;
				input += oddNumber;
				
			}

			Console.ReadLine();

		}
	}
}
