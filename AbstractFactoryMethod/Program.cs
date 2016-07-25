using System;
using Models;

namespace AbstractFactoryMethod
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var factory = new Factory();
			var product = factory.CreatProduct();

			Console.WriteLine("Product size: {0}", product.GetSize());
			Console.ReadKey();
		}
	}
}
