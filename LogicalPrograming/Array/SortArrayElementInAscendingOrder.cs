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
		// This method also called as Bubble sort
		static void Main(string[] args)
		{
			int[] arr = { 34, 64, 25, 12, 22, 11, 90 };

			var n = arr.Length;
					
			#region Method 1
			//Outer loop responsible for looping all number from array
			for (int i = 0; i < n - 1; i++)
			{
				//inner loop responsible for find lowest number and ten swap
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
