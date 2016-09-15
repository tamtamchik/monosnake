using System;
using System.Collections.Generic;

namespace monosnake
{
	public class Figure
	{
		protected List<Point> pList;

		public Figure()
		{
		}

		public void Draw()
		{
			foreach (Point p in pList)
			{
				p.Draw();
			}
		}

		internal bool IsHit(Figure figure)
		{
			foreach (Point p in pList)
			{
				if (figure.IsHit(p))
				{
					return true;
				}
			}

			return false;
		}

		private bool IsHit(Point point)
		{
			foreach (Point p in pList)
			{
				if (point.IsHit(p))
				{
					return true;
				}
			}

			return false;
		}
	}
}
