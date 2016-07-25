using System;
namespace Models
{
	public class Product : AbstractProduct
	{
		public override int Height { get; set; }

		public override int Width { get; set; }

		public override int GetSize()
		{
			return Height * Width;
		}
	}
}

