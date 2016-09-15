using System;
using System.Collections.Generic;
using System.Threading;

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

			Point p = new Point(4, 5, '*');
			Snake snake = new Snake(p, 4, Directions.RIGHT);

			snake.Draw();
			Thread.Sleep(300);
			snake.Move();
			Thread.Sleep(300);
			snake.Move();
			Thread.Sleep(300);
			snake.Move();
			Thread.Sleep(300);
			snake.Move();
			Thread.Sleep(300);
			snake.Move();


			Console.ReadLine();
		}
	}
}
