using System;

namespace Exp4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string? input;
            int choice;
            while (true)
            {
                Console.WriteLine("扫雷游戏");
                Console.WriteLine("1. 简单  2. 普通  3. 困难");
                Console.Write("请选择（输入q退出）：");
                input = Console.ReadLine();
                if (input == "q")
                    break;
                if (int.TryParse(input, out choice) && choice >= 1 && choice <= 3)
                {
                    choice--;
                    MineSweepingGame game = new MineSweepingGame((Level)choice);
                    game.ShowGameMap();
                }
                else
                {
                    Console.Write("输入有误！");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}