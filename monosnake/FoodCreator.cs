using System;
namespace monosnake
{
	public class FoodCreator
	{
		int mapWidth;
		int mapHeight;
		char sym;

		private ConsoleColor color = ConsoleColor.Red;

		Random random = new Random();

		public FoodCreator(int mapWidth, int mapHeight, char sym)
		{
			this.mapWidth = mapWidth;
			this.mapHeight = mapHeight;
			this.sym = sym;
		}

		internal Point CreateFood()
		{
			int x = random.Next(2, mapWidth - 2);
			int y = random.Next(2, mapHeight - 2);

			return new Point(x, y, sym, color);
		}
	}
}
