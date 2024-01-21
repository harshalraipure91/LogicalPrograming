using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class SimpleDemo
	{
		public int Value { get; set; }
	}
	internal class Simple
	{
		static void Main(string[] args)
		{
			SimpleDemo simpleDemo = new SimpleDemo();
			SimpleDemo simpleDemo2 = new SimpleDemo();

			//simpleDemo2 = simpleDemo;

			simpleDemo.Value = 10;
			simpleDemo2.Value = 25;

			//simpleDemo2 = simpleDemo;

			Console.WriteLine(simpleDemo.Value);
            Console.WriteLine(simpleDemo2.Value);

            Console.ReadLine();


        }
	}
}
