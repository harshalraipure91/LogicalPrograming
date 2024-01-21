using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class SearchElementInArray
	{
		static void Main(string[] args)
		{
			int[] arr = new int[50];
			int arraySize, searchElement;
			bool flag = false;

			Console.WriteLine("Enter an Size Of Array:");
			arraySize = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter an element in a Array:");
			for (int i = 0; i < arraySize; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}

			Console.WriteLine("Enter an element to search in Array:");
			searchElement = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < arraySize; i++)
			{
				if (arr[i] == searchElement)
				{
					flag = true;
					Console.WriteLine($"An element {searchElement} find in array at {i + 1} position");
				}
			}

			if (flag == false)
			{
				Console.WriteLine($"No element {searchElement} found in array");
			}


			Console.ReadLine();

		}
	}
}
