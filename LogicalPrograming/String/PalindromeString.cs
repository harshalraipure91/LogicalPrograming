using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class PalindromeString
	{
		static void Main(string[] args)
		{
			var input = "madam";
			var result = string.Empty;
			for (int i = input.Length - 1; i >= 0; i--)
			{
				result += input[i];
			}
			Console.WriteLine(input == result ? "Palindrome" : "Non Palindrome");
		}
	}
}
