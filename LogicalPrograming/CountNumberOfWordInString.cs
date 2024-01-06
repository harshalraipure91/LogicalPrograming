using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class CountNumberOfWordInString
	{
		static void Main(string[] args)
		{
			string input = "Hello World, How is doing?";
			bool isWord = false;
			int count = 0;

			for (int i = 0; i < input.Length; i++)
			{
				if (!char.IsWhiteSpace(input[i]) && !char.IsPunctuation(input[i]))
				{
					if (!isWord)
					{
						count++;
						isWord = true;						
					}
				}
				else
				{
					isWord = false;
				}
			}


            Console.WriteLine(count);
            Console.ReadLine();
        }
	}
}
