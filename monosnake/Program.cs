using System;
using System.Collections.Generic;

namespace monosnake
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int width = Console.BufferWidth - 1;
			int height = Console.BufferHeight - 1;

			HorizontalLine upLine = new HorizontalLine(0, width, 0, '+');
			HorizontalLine downLine = new HorizontalLine(0, width, height, '+');

			VerticalLine leftLine = new VerticalLine(0, height, 0, '+');
			VerticalLine rightLine = new VerticalLine(0, height, width, '+');

			upLine.Draw();
			downLine.Draw();
			leftLine.Draw();
			rightLine.Draw();

			Console.ReadLine();
		}
	}
}
