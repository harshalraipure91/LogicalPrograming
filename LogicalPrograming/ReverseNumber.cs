using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class ReverseNumber
	{
		static void Main(string[] args)
		{
			int input = 12345;
			int result = 0;

			while (input > 0)
			{
				var rem = input % 10;
				result = result * 10 + rem;
				input /= 10;
			}

            Console.WriteLine(result);

            Console.ReadLine();
        }
	}
}
