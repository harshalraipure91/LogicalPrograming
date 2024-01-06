using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{

	class ParentsClass
	{
		public virtual void ParentsClassVoidMethod()
		{
            Console.WriteLine("Parent class void method class.");
        }

		public void ParentsClassStringMethod(string Name)
		{
			Console.WriteLine($"Hello {Name}.");
		}
	}

	class ChildsClass : ParentsClass
	{
		public override void ParentsClassVoidMethod()
		{
			Console.WriteLine("Child class method class.");
		}

		public void CalledParentsClassMethod()
		{
			base.ParentsClassVoidMethod();
		}
	}



	internal class PolymorphismDemo
	{
		static void Main(string[] args)
		{
			ParentsClass parentsClass = new ParentsClass();
			parentsClass.ParentsClassVoidMethod();


			ChildsClass childsClass = new ChildsClass();
			childsClass.ParentsClassVoidMethod();
			childsClass.CalledParentsClassMethod();

            Console.WriteLine("--------------------");

			ParentsClass parentsClass2 = new ChildsClass();
			parentsClass2.ParentsClassVoidMethod();


			Console.ReadLine();
        }

	}
}
