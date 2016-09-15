using System;
namespace monosnake
{
	public class FoodCreator
	{
		int width;
		int height;
		char sym;

		Random random = new Random();

		public FoodCreator(int width, int height, char sym)
		{
			this.width = width;
			this.height = height;
			this.sym = sym;
		}

		internal Point CreateFood()
		{
			int x = random.Next(2, width - 2);
			int y = random.Next(2, height - 2);

			return new Point(x, y, sym);
		}
	}
}
