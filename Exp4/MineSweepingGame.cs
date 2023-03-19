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
            List<int> randNums = new List<int>();

            Random rand = new Random();
            int temp;
            while (randNums.Count < _mines)
            {
                temp = rand.Next(0, _row * _col - 1);
                if (!randNums.Contains(temp))
                {
                    randNums.Add(temp);
                }
            }
            int r, c;
            // 填数字
            foreach (int item in randNums)
            {
                r = item / _col;
                c = item % _col;

                for (int i = r - 1; i <= r + 1; i++)
                {
                    if (i >= 0 && i < _row)
                    {
                        for (int j = c - 1; j <= c + 1; j++)
                        {
                            if (j >= 0 && j < _col)
                            {
                                _map[i, j]++;
                            }
                        }
                    }
                }

                /*
                if (r - 1 >= 0)
                {
                    _map[r - 1, c]++;
                    if (c - 1 >= 0)
                        _map[r - 1, c - 1]++;
                    if (c + 1 <= _col)
                        _map[r - 1, c + 1]++;
                }
                if (r + 1 <= _row)
                {
                    _map[r + 1, c]++;
                    if (c - 1)
                }
                */
                /*
                if (r > 0 && r < _row - 1 && c > 0 && c < _col - 1)
                {
                    _map[r - 1, c - 1]++;
                    _map[r - 1, c]++;
                    _map[r - 1, c + 1]++;
                    _map[r + 1, c - 1]++;
                    _map[r + 1, c]++;
                    _map[r + 1, c + 1]++;
                    _map[r, c - 1]++;
                    _map[r, c + 1]++;
                }
                else
                {
                    if (r == 0)
                        _map[r + 1, c]++;
                    if (r == _row)
                        _map[r - 1, c]++;
                    if (c == 0)
                        _map[r, c + 1]++;
                    if (c == _col)
                        _map[r, c - 1]++;
                }
                */
            }
            foreach (int item in randNums)
            {
                r = item / _col;
                c = item % _col;
                _map[r, c] = 9;
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