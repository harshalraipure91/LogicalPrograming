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
			string input = "Google Doodlegg";

			input = input.ToLower().Replace(" ", string.Empty);

			while(input.Length > 0)
			{
                Console.Write(char.ToUpper(input[0]) + ":");
				int count = 0;
				for (int i = 0; i < input.Length; i++)
				{
					if (!char.IsPunctuation(input[0]))
					{
						if (input[0] == input[i])
							count++;
					}
				}
				
                Console.WriteLine(count);
				input = input.Replace(input[0].ToString(), string.Empty);
			}
            Console.ReadLine();

        }
	}
}
