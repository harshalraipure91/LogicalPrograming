using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
	sealed class SingletoClass
	{
		private static SingletoClass singletonClassObj;
		private static object obj;

		private SingletoClass()
		{

		}

		public static SingletoClass GetSingleInstance()
		{
			lock (obj)
			{

				if (singletonClassObj == null)
					singletonClassObj = new SingletoClass();
			}
			return singletonClassObj;
		}
	}
	internal class SingletoneDesignPattern
	{
		static void Main(string[] args)
		{
			SingletoClass s1 = SingletoClass.GetSingleInstance();
			SingletoClass s2 = SingletoClass.GetSingleInstance();
		}
	}
}
