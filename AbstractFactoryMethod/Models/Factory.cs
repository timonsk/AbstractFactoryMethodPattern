using System;
namespace Models
{
	public class Factory : AbstractFactory
	{
		public override AbstractProduct CreatProduct()
		{
			return new Product() {  Height = 10, Width = 15};
		}
	}
}

