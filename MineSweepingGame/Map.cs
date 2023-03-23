using System;

namespace MineSweepingGame
{
    public class Map
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int MineCount { get; set; }
        public int[,] MapData { get; set; }

        public Map(int width, int height, int mineCount)
        {
            Width = width;
            Height = height;
            MineCount = mineCount;
            MapData = new int[width, height];
        }

        public void InitMap()
        {
            Random random = new Random();
            for (int i = 0; i < MineCount; i++)
            {
                int x = random.Next(0, Width);
                int y = random.Next(0, Height);
                if (MapData[x, y] == 9)
                {
                    i--;
                    continue;
                }
                MapData[x, y] = 9;

                for (int j = x - 1; j <= x + 1; j++)
                {
                    for (int k = y - 1; k <= y + 1; k++)
                    {
                        if (j >= 0 && j < Width && k >= 0 && k < Height && MapData[j, k] != 9)
                        {
                            MapData[j, k]++;
                        }
                    }
                }
            }
        }

        public void ShowMap()
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Console.Write(MapData[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}