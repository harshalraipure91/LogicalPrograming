using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class SortStringInAlphabeticalOrder
	{
		static void Main(string[] args)
		{
			var input = "Harshal";
			input = input.ToLower();
			var inputArray = input.ToCharArray();
			var n = inputArray.Length;

			#region Method 1

			//for (int i = 0; i < n - 1; i++)
			//{
			//	for (int j = 0; j < n - i - 1; j++)
			//	{
			//		if (charArray[j] > charArray[j + 1])
			//		{
			//			var temp = charArray[j];
			//			charArray[j] = charArray[j + 1];
			//			charArray[j + 1] = temp;
			//		}
			//	}
			//}

			#endregion

			#region Method 2
			for (int i = 0; i < n - 1; i++)
			{
				for (int j = i + 1; j < n; j++)
				{
					if (inputArray[i] > inputArray[j])
					{
						var temp = inputArray[i];
						inputArray[i] = inputArray[j];
						inputArray[j] = temp;
					}
				}
			}

			#endregion
			input = new string(inputArray);
			Console.WriteLine(input);

			Console.ReadLine();
		}
	}
}
