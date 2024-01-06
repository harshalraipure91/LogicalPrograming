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
			var inputStr = "Harshal";
			inputStr = inputStr.ToLower();
			var charArray = inputStr.ToCharArray();
			var n = charArray.Length;

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
					if (charArray[i] > charArray[j])
					{
						var temp = charArray[i];
						charArray[i] = charArray[j];
						charArray[j] = temp;
					}
				}
			}

			#endregion

			Console.WriteLine(charArray);

			Console.ReadLine();
		}
	}
}
