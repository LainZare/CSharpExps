using System;

namespace Exp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quiz quiz = new Quiz();
            string stringAnswer;
            double doubleAnswer;
            bool right;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("(按q可以退出)");
                Console.Write(quiz.GetQuiz());
                stringAnswer = Console.ReadLine();
                // 检查用户输入
                if (double.TryParse(stringAnswer, out doubleAnswer))
                {
                    // 检查答案
                    right = quiz.CheckAnswer(doubleAnswer);
                    if (right)
                    {
                        Console.WriteLine("正确");
                    }
                    else
                    {
                        Console.WriteLine($"错误，正确答案为{quiz.GetResult()}");
                    }
                }
                else if (stringAnswer == "q")
                {
                    Console.WriteLine("再见");
                    break;
                }
                else
                {
                    Console.WriteLine("输入有误");
                }
                Console.WriteLine("按Enter继续，按q可以退出");
                if (Console.ReadLine() == "q")
                {
                    Console.WriteLine("再见");
                    break;
                }
            }
        }
    }
}
