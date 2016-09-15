using System;
using System.Collections.Generic;

namespace monosnake
{
	public class Walls
	{
		List<Figure> wallsList;

		public Walls(int mapWidth, int mapHeight)
		{
			wallsList = new List<Figure>();

			HorizontalLine upLine = new HorizontalLine(0, mapWidth, 0, '+');
			HorizontalLine downLine = new HorizontalLine(0, mapWidth, mapHeight, '+');

			VerticalLine leftLine = new VerticalLine(0, mapHeight, 0, '+');
			VerticalLine rightLine = new VerticalLine(0, mapHeight, mapWidth, '+');

			wallsList.Add(upLine);
			wallsList.Add(downLine);
			wallsList.Add(leftLine);
			wallsList.Add(rightLine);
		}

		public void Draw()
		{
			foreach (Figure wall in wallsList)
			{
				wall.Draw();
			}
		}

		internal bool IsHit(Figure figure)
		{
			foreach (Figure wall in wallsList)
			{
				if (wall.IsHit(figure))
				{
					return true;
				}
			}

			return false;
		}
	}
}
