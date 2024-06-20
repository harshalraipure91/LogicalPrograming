using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class RemoveDuplicateCharInString
	{
		static void Main(string[] args)
		{
			var inputString = "Harshal Raipure";
			var result = string.Empty;

			for (int i = 0; i < inputString.Length; i++)
			{
				if (!result.Contains(inputString[i]))
				{
					result += inputString[i];
				}
			}
			Console.WriteLine(result);
		}
	}
}
