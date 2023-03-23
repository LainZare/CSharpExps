using System;
using System.Collections.Generic;

namespace Exp4
{
    public class MineSweepingGame
    {
        private int _mines;
        private int[,] _map;
        private int _row, _col;

        public MineSweepingGame(Level level)
        {
            #region 创建地图
            switch (level)
            {
                case Level.Simple:
                    _row = 9;
                    _col = 9;
                    _mines = 10;
                    break;
                case Level.Normal:
                    _row = 16;
                    _col = 16;
                    _mines = 40;
                    break;
                case Level.Hard:
                    _row = 30;
                    _col = 16;
                    _mines = 99;
                    break;
            }
            _map = new int[_row, _col];
            #endregion

            #region 布雷
            Random rand = new Random();
            List<int> randNums = new List<int>();
            int temp;
            while (randNums.Count < _mines)
            {
                temp = rand.Next(0, _row * _col);
                if (!randNums.Contains(temp))
                {
                    randNums.Add(temp);
                }
            }
            // 填数字，以雷为中心，八个方向若存在，则该位置+1
            int r, c;
            int i, j;
            foreach (int item in randNums)
            {
                r = item / _col;
                c = item % _col;

                for (i = r - 1; i <= r + 1; i++)
                {
                    if (i >= 0 && i < _row)
                    {
                        for (j = c - 1; j <= c + 1; j++)
                        {
                            if (j >= 0 && j < _col)
                            {
                                _map[i, j]++;
                            }
                        }
                    }
                }

            }
            // 上步可能会更改雷区的数字，需要在最后为雷区填数字
            foreach (int item in randNums)
            {
                _map[item / _col, item % _col] = 9;
            }
            #endregion
        }
        public void ShowGameMap()
        {
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    Console.Write($"{_map[i, j]}  ");
                }
                Console.WriteLine();
            }
        }
    }
}