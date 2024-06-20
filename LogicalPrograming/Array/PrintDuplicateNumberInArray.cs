using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class PrintDuplicateNumberInArray
	{
		static void Main(string[] args)
		{
			int[] array = { 1, 2, 3, 10, 5, 4, 3, 8, 9, 7, 5, 1 };

			#region Method 2

			var duplicate = array.GroupBy(x => x).Where(y => y.Count() > 1).Select(z => z.Key);
			foreach (var item in duplicate)
			{
				Console.WriteLine($"Duplicate number in array is: {item}");
			}

            #endregion

            #region Method1

            //for (int i = 0; i < array.Length; i++)
            //{
            //	for (int j = i + 1; j < array.Length; j++)
            //	{
            //		if (array[i] == array[j])
            //		{
            //			Console.WriteLine($"Duplicate number in array is: {array[i]}");
            //		}
            //	}

            //}

            #endregion


            Console.ReadLine();
		}
	}
}
