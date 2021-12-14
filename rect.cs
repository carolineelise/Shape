using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrillateral
{
	class Rect : Shape
	{
		public new void Print()
		{
			Console.WriteLine($"Perimeter: {Perimeter()}; Area: {Area()}");
		}
		public int Area()
		{
			return Side1 * Side2;
		}
		public Rect(int SideA, int SideB) : base(SideA, SideB, SideA, SideB)
		{
		}
	}
}