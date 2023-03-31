using System;
using System.IO;

namespace Exp5
{
    class Program
    {
        public static void Main(string[] args)
        {

            #region 读取文件
            string[] choiceQuestions;
            string[] clozeQuestions;
            string[] translateQuestions;
            try
            {
                StreamReader sr = new StreamReader("ChoiceQuestions.txt");
                string lines = sr.ReadToEnd();
                choiceQuestions = lines.Split('\n');
                sr.Close();
                sr = new StreamReader("ClozeQuestions.txt");
                lines = sr.ReadToEnd();
                clozeQuestions = lines.Split('\n');
                sr.Close();
                sr = new StreamReader("TranslateQuestions.txt");
                lines = sr.ReadToEnd();
                translateQuestions = lines.Split('\n');
            }
            catch (IOException)
            {
                Console.WriteLine("File not found!");
                return;
            }
            int choiceQuestionsNum = choiceQuestions.Length / 3;
            int clozeQuestionsNum = clozeQuestions.Length / 2;
            int translateQuestionsNum = translateQuestions.Length / 2;
            #endregion

            #region 获取题目数量
            int inputedChoiceNum;
            int inputedClozeNum;
            int inputedTranslateNum;
            try
            {
                while (true)
                {
                    Console.WriteLine($"请输入选择题数量（1-{choiceQuestionsNum}）：");

                    if (int.TryParse(Console.ReadLine(), out inputedChoiceNum)
                        && inputedChoiceNum >= 1 && inputedChoiceNum <= choiceQuestionsNum)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("输入错误！");
                    }
                }
                while (true)
                {
                    Console.WriteLine($"请输入填空题数量（1-{clozeQuestionsNum}）：");

                    if (int.TryParse(Console.ReadLine(), out inputedClozeNum)
                        && inputedClozeNum >= 1 && inputedClozeNum <= clozeQuestionsNum)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("输入错误！");
                    }
                }
                while (true)
                {
                    Console.WriteLine($"请输入翻译题数量（1-{translateQuestionsNum}）：");

                    if (int.TryParse(Console.ReadLine(), out inputedTranslateNum)
                        && inputedTranslateNum >= 1 && inputedTranslateNum <= translateQuestionsNum)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("输入错误！");
                    }
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("输入错误！");
                return;
            }
            // 答案数组
            List<string> answers = new List<string>();
            #endregion

            System.Console.WriteLine("============================================");
            System.Console.WriteLine("试卷已生成，按任意键开始考试");
            System.Console.WriteLine("============================================");
            Console.ReadKey();

            #region 随机输出题目
            Random random = new Random();
            List<int> randNums = new List<int>();
            int randNum;
            int i;
            for (i = 0; i < inputedChoiceNum; i++)
            {
                randNum = random.Next(0, choiceQuestionsNum);
                while (randNums.Contains(randNum))
                {
                    randNum = random.Next(0, choiceQuestionsNum);
                }
                randNums.Add(randNum);
            }
            int questionNumber = 1;
            foreach (int item in randNums)
            {
                Console.Write($"{questionNumber++}. ");
                System.Console.WriteLine(choiceQuestions[item * 3]);
                System.Console.WriteLine(choiceQuestions[item * 3 + 1]);
                System.Console.WriteLine();
                answers.Add(choiceQuestions[item * 3 + 2]);
            }
            randNums.Clear();
            for (i = 0; i < inputedClozeNum; i++)
            {
                randNum = random.Next(0, clozeQuestionsNum);
                while (randNums.Contains(randNum))
                {
                    randNum = random.Next(0, clozeQuestionsNum);
                }
                randNums.Add(randNum);
            }
            foreach (int item in randNums)
            {
                Console.Write($"{questionNumber++}. ");
                System.Console.WriteLine(clozeQuestions[item * 2]);
                System.Console.WriteLine();
                answers.Add(clozeQuestions[item * 2 + 1]);
            }
            randNums.Clear();
            for (i = 0; i < inputedTranslateNum; i++)
            {
                randNum = random.Next(0, translateQuestionsNum);
                while (randNums.Contains(randNum))
                {
                    randNum = random.Next(0, translateQuestionsNum);
                }
                randNums.Add(randNum);
            }
            foreach (int item in randNums)
            {
                Console.Write($"{questionNumber++}. ");
                System.Console.WriteLine(translateQuestions[item * 2]);
                System.Console.WriteLine();
                answers.Add(translateQuestions[item * 2 + 1]);
            }
            #endregion

            #region 显示答案
            System.Console.WriteLine("============================================");
            System.Console.WriteLine("按任意键查看答案");
            System.Console.WriteLine("============================================");
            Console.ReadKey();
            questionNumber = 1;
            foreach (string item in answers)
            {
                Console.Write($"{questionNumber++}. ");
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("============================================");
            #endregion
        }
    }
}