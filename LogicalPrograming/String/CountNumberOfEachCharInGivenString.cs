using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class CountNumberOfEachCharInGivenString
	{
		static void Main(string[] args)
		{
			string input = "Google Doodle";
			input = input.ToLower().Replace(" ", string.Empty);

			#region Using while loop

			//while(input.Length > 0)
			//{
			//             Console.Write(char.ToUpper(input[0]) + ":");
			//	int count = 0;
			//	for (int i = 0; i < input.Length; i++)
			//	{
			//		if (!char.IsPunctuation(input[0]))
			//		{
			//			if (input[0] == input[i])
			//				count++;
			//		}
			//	}

			//             Console.WriteLine(count);
			//	input = input.Replace(input[0].ToString(), string.Empty);
			//}
			#endregion

			#region Using dictonary

			//dictionary<char, int> charcount = new dictionary<char, int>();

			//foreach (char c in input)
			//{
			//	if (charcount.containskey(c))
			//	{
			//		charcount[c]++;
			//	}
			//	else
			//	{
			//		charcount[c] = 1;
			//	}
			//}

			//list<char> list = new list<char>(charcount.keys);

			//foreach (char c in list)
			//{
			//	console.writeline($"{c}- {charcount[c]}");
			//	// remove the character from the dictionary to avoid printing duplicates
			//	charcount.remove(c);
			//}
			#endregion

			#region

			List<char> chars = new List<char>();
			List<int> counts = new List<int>();

			// Iterate over each character in the input string
			foreach (var item in input)
			{
				// Check if the character already exists in the list
				var index = chars.IndexOf(item);
				if(index != -1)
				{
					// If the character exists, increment its count
					counts[index]++;
				}
				else
				{
					// If the character doesn't exist, add it to the list
					chars.Add(item);
					counts.Add(1);
				}
			}

			// Print the count of each character
			for (int i = 0; i < chars.Count; i++)
			{
				Console.WriteLine($"{chars[i]}- {counts[i]}");
			}

			#endregion
		}
	}
}
