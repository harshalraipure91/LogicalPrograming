using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class SortArrayElementInAscendingOrder
	{
		static void Main(string[] args)
		{
			int[] arr = { 34, 64, 25, 12, 22, 11, 90 };

			var n = arr.Length;

			#region Method 1

			//for (int i = 0; i < n - 1; i++)
			//{
			//	for (int j = 0; j < n - i - 1; j++)
			//	{
			//		if (arr[j] > arr[j + 1])
			//		{
			//			var temp = arr[j];
			//			arr[j] = arr[j + 1];
			//			arr[j + 1] = temp;
			//		}
			//	}
			//}

			#endregion

			#region Method 2

			for (int i = 0; i < n - 1; i++)
			{
				for (int j = i + 1; j < n; j++)
				{
					if (arr[i] > arr[j])
					{
						var temp = arr[i];
						arr[i] = arr[j];
						arr[j] = temp;
					}
				}
			}

			#endregion

			foreach (var item in arr)
			{
				Console.Write(item + " ");
			}

			Console.ReadLine();
		}
	}
}
