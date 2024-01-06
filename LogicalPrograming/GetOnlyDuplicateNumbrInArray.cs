using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class GetOnlyDuplicateNumbrInArray
	{
		static void Main(string[] args)
		{
			int[] aaray = { 1, 2, 3, 10, 5, 4, 3, 8, 9, 7, 5, 1 };

			#region Method 2

			var duplicate = aaray.GroupBy(x => x).Where(y => y.Count() > 1).Select(z => z.Key);
			foreach (var item in duplicate)
			{
				Console.WriteLine($"Duplicate number in array is: {item}");
			}

			#endregion

			#region Method1

			//for (int i = 0; i < aaray.Length; i++)
			//{
			//	for (int j = i + 1; j < aaray.Length; j++)
			//	{
			//		if (aaray[i] == aaray[j])
			//		{
			//			Console.WriteLine($"Duplicate number in array is: {aaray[i]}");
			//		}
			//	}

			//}

			#endregion


			Console.ReadLine();
		}
	}
}
