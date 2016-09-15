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

			Walls walls = new Walls(width, height);
			walls.Draw();

			Point p = new Point(4, 5, '*');
			Snake snake = new Snake(p, 4, Directions.RIGHT);

			snake.Draw();

			FoodCreator foodCreator = new FoodCreator(width, height, '$');
			Point food = foodCreator.CreateFood();
			food.Draw();

			while (true)
			{
				if (walls.IsHit(snake) || snake.IsHitTail())
				{
					break;
				}

				if (snake.Eat(food))
				{
					food = foodCreator.CreateFood();
					food.Draw();
				}
				else {
					snake.Move();
				}

				Thread.Sleep(300);

				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);

					if (key.Key == ConsoleKey.Escape) break;
				}
			}

			WriteGameOver();
			Console.ReadLine();
		}

		static void WriteGameOver()
		{
			int xOffset = 25;
			int yOffset = 8;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.SetCursorPosition(xOffset, yOffset++);
			WriteText("============================", xOffset, yOffset++);
			WriteText("     G A M E    O V E R     ", xOffset + 1, yOffset++);
			WriteText("============================", xOffset, yOffset++);
		}

		static void WriteText(String text, int xOffset, int yOffset)
		{
			Console.SetCursorPosition(xOffset, yOffset);
			Console.WriteLine(text);
		}
	}
}
