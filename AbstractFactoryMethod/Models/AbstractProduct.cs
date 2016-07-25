using System;
namespace Models
{
	public abstract class AbstractProduct
	{
		public abstract int Width { get; set; }
		public abstract int Height { get; set; }
		public abstract int GetSize();
	}
}

