using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class YieldDemo
	{

		//"yield" keyword will act as an iterator blocker and generate or return values
		static void Main(string[] args)
		{
			var result = GetEvenNumber(10);
			foreach (var value in result)
			{
				Console.WriteLine(value);
			}
            
        }

		public static IEnumerable<int> GetEvenNumber(int values)
		{
			//List<int> numbers = new List<int>();

			for (int i = 0; i <= values; i +=2)
			{
				//numbers.Add(i);
				yield return i;
                Console.WriteLine("Print");
            }
			//return numbers;
		}


	}
}
