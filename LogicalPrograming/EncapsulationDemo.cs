using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{

	class Person
	{
		private string name;
		private int age;

		public Person(string Name, int Age)
		{
			this.name = Name;
			this.age = Age;
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public int Age
		{
			get { return age; }
			set { age = value; }
		}
	}
	internal class EncapsulationDemo
	{
		static void Main(string[] args)
		{
			Person persons = new Person("Harshal",32);
            Console.WriteLine(persons.Name);
            Console.WriteLine(persons.Age);

            Console.WriteLine("---------------------");

			persons.Name = "Akash";
			persons.Age = 27;

			Console.WriteLine(persons.Name);
			Console.WriteLine(persons.Age);

            Console.ReadLine();
        }
	}
}
