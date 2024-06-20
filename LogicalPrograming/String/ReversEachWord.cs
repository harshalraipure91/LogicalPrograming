using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class ReversEachWord
	{
		static void Main(string[] args)
		{
			string input = "Hello Harshal How are you";
			var splitInput = input.Split(' ');

			for (int i = 0; i < splitInput.Length; i++)
			{
				var split = splitInput[i];
				var result = string.Empty;
				for (int j = split.Length - 1; j >= 0; j--)
				{
					result += split[j];
				}
				splitInput[i] = result;
			}
			input = string.Join(" ", splitInput);

			Console.WriteLine(input);

			Console.ReadLine();
		}
	}
}
