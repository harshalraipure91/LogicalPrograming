using System;
using System.Linq;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class PrintNonDublicateNumberInArray
	{
		static async Task Main(string[] args)
		{

			int[] aaray = { 1, 1, 2, 3, 4, 5, 5, 6, 7, 8, 9, 9 };

			#region Method 1

			//Console.WriteLine("Non-duplicate numbers in the array are:");

			//for (int i = 0; i < aaray.Length; i++)
			//{
			//	bool isDuplicate = false;
			//	for (int j = i + 1; j < aaray.Length; j++)
			//	{
			//		if (aaray[i] == aaray[j])
			//		{
			//			isDuplicate = true;
			//			break;
			//		}
			//	}

			//	if (!isDuplicate)
			//	{
			//		Console.WriteLine(aaray[i]);
			//	}
			//}

			#endregion

			#region Method 2

			//var duplicate aaray= await Task.Run(() => aaray.Distinct().ToList());

			//foreach (var item in duplicate)
			//{
			//	Console.Write(item + " ");
			//}

			#endregion

			#region Method 3

			var duplicate = aaray.Distinct().ToArray();
			var duplicates = string.Join(" ", duplicate);
            await Console.Out.WriteLineAsync(duplicates);

            #endregion


            Console.ReadLine();



		}
	}
}
