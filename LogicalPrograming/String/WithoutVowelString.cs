using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class WithoutVowelString
	{
		static void Main(string[] args)
		{
			string inputString = "Hello World";
			string output = string.Empty;

			for (int i = 0; i < inputString.Length; i++)
			{
				if (!"aeiouAEIOU".Contains(inputString[i]))
				{
					output += inputString[i];					
				}
			}
			Console.WriteLine($"Exclude vowel from string: {output}");
			Console.ReadLine();
        }
	}
}
