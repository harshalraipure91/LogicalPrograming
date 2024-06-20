using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class NumberPatternProgram2
	{
		#region Output
		/*
		 Output:
		 =======
		
		1
		22
		333
		4444
		55555
		 
		 */
		#endregion
		static void Main(string[] args)
		{
			for (int i = 1; i <= 5; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write(i);
				}
				Console.WriteLine();
			}			
			Console.ReadLine();
		}

	}
}
