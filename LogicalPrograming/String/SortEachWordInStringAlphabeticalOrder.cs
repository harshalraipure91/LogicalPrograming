using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class SortEachWordInStringAlphabeticalOrder
	{
		static void Main(string[] args)
		{
			string inputStr = "Good Morning";
			var spliInputStr = inputStr.ToLower().Split(' ');

			for (int i = 0; i < spliInputStr.Length; i++)
			{
				var newInput = spliInputStr[i].ToCharArray();

				for (int j = 0; j < newInput.Length - 1; j++)
				{
					for (int k = j + 1; k < newInput.Length; k++)
					{
						if (newInput[j] > newInput[k])
						{
							var temp = newInput[j];
							newInput[j] = newInput[k];
							newInput[k] = temp;
						}
					}
				}
				spliInputStr[i] = new string(newInput);
			}
			inputStr = string.Join(" ", spliInputStr);

            Console.WriteLine(inputStr);

            Console.ReadLine();
		}
	}
}
