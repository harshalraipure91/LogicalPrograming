using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class MaximumOrMinimumElementInArray
	{
		static void Main(string[] args)
		{
			int MaxElement, MaxElement2;
			int[] array = { 12, 45, 67, 69, 23, 9, 41, 8 };

			#region With Build In MEthod

			//Find Max element

			//var MaxElement = array.Max();
			// Console.WriteLine($"Maximum element in array is: {MaxElement}");


			//Find Min element

			//var MinElement = array.Min();
			//Console.WriteLine($"Manimum element in array is: {MinElement}");


			#endregion

			#region Without Build In MEthod

			//Find Max Element

			MaxElement = MaxElement2 = array[0];

			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] > MaxElement)
				{
					MaxElement2 = MaxElement;
					MaxElement = array[i];
				}
				else if (array[i] > MaxElement2)
				{
					MaxElement2 = array[i];
				}
			}
			Console.WriteLine($"Maximum element in array is: {MaxElement}");
			Console.WriteLine($"2nd Maximum element in array is: {MaxElement2}");

			//Find Min Element

			int MinElement, MinElement2;

			MinElement = MinElement2 = array[0];

			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] < MinElement)
				{
					MinElement2 = MinElement;
					MinElement = array[i];
				}
				else if(array[i] < MinElement2)
				{
					MinElement2 = array[i];
				}
					
			}
			Console.WriteLine($"Manimum element in array is: {MinElement}");
			Console.WriteLine($"2nd Manimum element in array is: {MinElement2}");

			#endregion

			Console.ReadLine();
		}
	}
}
