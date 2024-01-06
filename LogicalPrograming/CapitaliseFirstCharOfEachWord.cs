using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class CapitaliseFirstCharOfEachWord
	{
		static void Main(string[] args)
		{
			string input = "hello harshal, i am HEre to heLp yoU!";
			var splitInput = input.Split(' ');

			for (int i = 0; i < splitInput.Length; i++)
			{
				var firstChar = char.ToUpper(splitInput[i][0]);
				var remainingChar = splitInput[i].Substring(1).ToLower();

				//splitInput[i] = string.Concat(firstChar, remainingChar);
				//splitInput[i] = $"{firstChar}{remainingChar}";
				splitInput[i] = firstChar + remainingChar;
			}

			input = string.Join(" ", splitInput);

			Console.WriteLine(input);

			Console.ReadLine();
		}
	}
}
