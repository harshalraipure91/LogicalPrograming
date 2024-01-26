using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class DiamondPatterns
	{
		#region Output
		/*
		 Output:
		 =======
		
		----*
		___****
		__******
		_********
			
		 
		 */
		#endregion
		static void Main(string[] args)
		{
			for (int i = 1; i <= 5; i++)
			{
				for (int j = i; j <= 4; j++)
				{
					Console.Write(" ");
				}

				for (int k = 1; k <= i; k++)
				{
					Console.Write("*");
				}
				for (int l = 2; l <= i; l++)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}
			for (int i = 2; i <= 5; i++)
			{
				for (int j = 2; j <= i; j++)
				{
					Console.Write(" ");
				}

				for (int k = i; k <= 5; k++)
				{
					Console.Write("*");
				}
				for (int l = i; l <= 4; l++)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}

			Console.ReadLine();
		}

	}
}
