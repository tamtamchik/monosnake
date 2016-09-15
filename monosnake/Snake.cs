using System;
using System.Collections.Generic;
using System.Linq;

namespace monosnake
{
	public class Snake : Figure
	{
		Directions direction;

		private ConsoleColor color = ConsoleColor.Green;

		public Snake(Point tail, int length, Directions _direction)
		{
			direction = _direction;
			pList = new List<Point>();
			tail.color = this.color;

			for (int i = 0; i < length; i++)
			{
				Point p = new Point(tail);
				p.Move(i, direction);
				pList.Add(p);
			}
		}

		public void Move()
		{
			Point tail = pList.First();
			pList.Remove(tail);
			Point head = GetNextPoint();
			pList.Add(head);

			tail.Clear();
			Draw();
		}

		public Point GetNextPoint()
		{
			Point head = pList.Last();
			Point nextPoint = new Point(head);
			nextPoint.Move(1, direction);

			return nextPoint;
		}

		internal bool IsHitTail()
		{
			Point head = pList.Last();

			for (int i = 0; i < pList.Count - 2; i++) {
				
				if (head.IsHit(pList[i])) {
					return true;	
				}
			}

			return false;
		}

		public void HandleKey(ConsoleKey key)
		{
			if (key == ConsoleKey.LeftArrow)
				direction = Directions.LEFT;
			else if (key == ConsoleKey.RightArrow)
				direction = Directions.RIGHT;
			else if (key == ConsoleKey.UpArrow)
				direction = Directions.UP;
			else if (key == ConsoleKey.DownArrow)
				direction = Directions.DOWN;
		}

		internal bool Eat(Point food)
		{
			Point head = GetNextPoint();

			if (head.IsHit(food))
			{
				food.sym = head.sym;
				food.color = color;
				food.Draw();
				pList.Add(food);

				return true;
			}

			return false;
		}
	}
}
