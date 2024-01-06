using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class ReverseString
	{
		static void Main(string[] args)
		{
			#region Method 1
			//string inputString = "HArshal";
			//var result = string.Empty;

			//for (int i = inputString.Length-1; i >=0; i--)
			//{
			//	result += inputString[i];
			//}
   //         Console.WriteLine(result);
			#endregion

			#region Method 2
			string inputString = "Harshal";
			var charArray = inputString.Trim().ToCharArray();
			Array.Reverse(charArray);
			var result = new string(charArray);

            Console.WriteLine(result);
            #endregion

            Console.ReadLine();
		}
	}
}
