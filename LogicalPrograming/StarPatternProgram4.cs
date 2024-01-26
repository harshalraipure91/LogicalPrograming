using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class StarPatternProgram4
	{
		#region Output
		/*
		 Output:
		 =======
		
		*
		**
		***
		****
		*****
		****
		***
		**
		*
		 
		 */
		#endregion
		static void Main(string[] args)
		{
			for (int i = 1; i <= 5; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			for (int i = 1; i <= 4; i++)
			{
				for (int j = i; j <= 4; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			Console.ReadLine();
		}

	}
}
