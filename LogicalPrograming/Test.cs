using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	internal class Test
	{
		readonly int number;
		const int number2 = 52;

        public Test()
        {
			
		}
        static void Main(string[] args)
		{
			#region 2 5 10 17 26 37

			//int input = 2; // The starting value
			//int oddNumber = 1; // The first odd number to add


			//for (int i = 0; i < 6; i++)
			//{
			//	Console.Write(input+" ");
			//	oddNumber += 2;
			//	input += oddNumber;

			//}

			#endregion

			#region CASE1 ASSIGN Object of One Class to Object of another class
			//classA A = new classA();
			//classB B = new classB();

			//B = A;  // We can't assign an object of one class to object of other class directly,
			// For that we have to make relation between classe ie, inheritance or implement through interface 

			#endregion

			#region
			//Test obj = new Test();			
			//Console.WriteLine(number2);

			#endregion

			#region
			classA A = new classA();
			classB B = new classB();
			A.Value1 = 25;
			B.Value1 = A.Value1;
			A.Value1 = 35;
            Console.WriteLine(B.Value1);
            Console.WriteLine(A.Value1);

            #endregion

            Console.ReadLine();

		}
		class classA
		{
            public int Value1 { get; set; }
        }
		class classB
		{
			public int Value1 { get; set; }
		}
	}
}
