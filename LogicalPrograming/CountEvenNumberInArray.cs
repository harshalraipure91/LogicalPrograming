using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class CountEvenNumberInArray
	{
		static void Main(string[] args)
		{
			int[] arr = new int[50];
			int size;
			int count = 0;

			Console.WriteLine("Enter the size of array: ");
			size = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter an element in array: ");
			for (int i = 0; i < size; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
				if (arr[i] % 2 == 0)
				{
					count++;
				}
			}
			Console.WriteLine($"Total number of even element in array is {count} ");

			Console.ReadLine();


		}
	}
}
