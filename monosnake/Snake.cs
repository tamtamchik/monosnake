using System;
using System.Collections.Generic;

namespace monosnake
{
	public class Snake : Figure
	{
		public Snake(Point tail, int length, Directions direction)
		{
			pList = new List<Point>();

			for (int i = 0; i < length; i++)
			{
				Point p = new Point(tail);
				p.Move(i, direction);
				pList.Add(p);
			}
		}
	}
}
