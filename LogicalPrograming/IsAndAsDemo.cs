using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	public class IsAndAsDemo
	{
		static void Main(string[] args)
		{
			int a = 5;
			object b = "Hello";

			bool ok = a is int;

			string name = b as string;

			Console.WriteLine(ok);
			Console.WriteLine(name);


		}
	}
}
