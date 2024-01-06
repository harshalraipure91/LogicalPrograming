using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	interface InterfaceDemo
	{
		void InterfaceMethod(string name);
	}

	abstract class AbstractSample
	{
		public abstract void SampleMethod();
		public  void SampleMethod( string name)
		{
            Console.WriteLine($"Hello {name}");
        }
		
	}

	class Demo : AbstractSample, InterfaceDemo
	{
		public override void SampleMethod()
		{
			Console.WriteLine("Override abstract method called");
		}
		public void InterfaceMethod(string name)
		{
            Console.WriteLine($"Hello {name} interface method is called.");
        }		
	}

	internal class AbstractClassDemo 
	{
		static void Main(string[] args)
		{		

			Demo demos = new Demo();
			demos.SampleMethod();
			demos.InterfaceMethod("Harshal");
			demos.SampleMethod("Vikas"); //called non-abstract method of Abstract class 


            Console.ReadLine();
        }
				
	}
}
