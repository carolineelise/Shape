using System;

using System;

namespace Quadrillateral
{
	class Program
	{
		static void Main(string[] args)
		{
			var s1 = new sqr()
			{
				Side1 = 5, Side2 = 5, Side3 = 5, Side4 = 5
			};
			Console.WriteLine($"Perimeter is {s1.Perimeter()}");
			Console.WriteLine($"Area is {s1.Area()}");

			var r1 = new rect()
			{
				Side1 = 3,
				Side2 = 5
			};
			Console.WriteLine($"Perimeter is {r1.Perimeter()}");
			Console.WriteLine($"Area is {r1.Area()}");

			var q1 = new Shape()
			{
				Side1 = 3,
				Side2 = 4,
				Side3 = 5,
				Side4 = 6
			};
			Console.WriteLine($"Perimeter is {q1.Perimeter()}");
		}
	}
}