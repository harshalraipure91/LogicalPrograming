using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class ReverseArray
	{
		static void Main(string[] args)
		{
			int[] array = { 1, 2, 3, 25, 35, 4, 5, 6, 7, 8, 9 };


			for (int i = 0; i < array.Length - 1; i++)
			{
				for (int j = i + 1; j < array.Length; j++)
				{
					var temp = array[i];
					array[i] = array[j];
					array[j] = temp;
				}
			}
			foreach (var item in array)
			{
				Console.Write(item + " ");
			}


			Console.ReadLine();
		}
	}
}
