using System;

namespace monosnake
{
	public class Point
	{
		public int x;
		public int y;
		public char sym;
		public ConsoleColor color;

		public Point()
		{
		}

		public Point(int x, int y, char sym, ConsoleColor color = ConsoleColor.Blue)
		{
			this.x = x;
			this.y = y;	
			this.sym = sym;
			this.color = color;
		}

		public Point(Point p)
		{
			this.x = p.x;
			this.y = p.y;
			this.sym = p.sym;
			this.color = p.color;
		}

		public void Move(int offset, Directions direction)
		{
			if (direction == Directions.RIGHT)
			{
				x = x + offset;
			}
			else if (direction == Directions.LEFT)
			{
				x = x - offset;
			}
			else if (direction == Directions.UP)
			{
				y = y - offset;
			}
			else if (direction == Directions.DOWN)
			{
				y = y + offset;
			}
		}

		public void Draw()
		{
			Console.ForegroundColor = this.color;
			Console.SetCursorPosition(x, y);
			Console.Write(sym);
		}

		public void Clear()
		{
			sym = ' ';
			Draw();
		}

		public bool IsHit(Point p)
		{
			return p.x == x && p.y == y;
		}

		public override string ToString()
		{
			return x + ", " + y + ", " + sym;
		}
	}
}
