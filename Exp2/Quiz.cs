using System;
using System.Threading;

namespace Exp2
{
    class Quiz
    {
        // 三个随机数，前两个用于参与运算，最后一个决定运算方式
        private Random randNum1, randNum2;
        private int num1, num2;
        private int operation;
        private double result;
        private string question;
        private const double MIN_NUM = 0.00000001;
        public Quiz()
        {
            randNum1 = new Random();
            Thread.Sleep(100);
            randNum2 = new Random();
        }
        public double GetResult()
        {
            return result;
        }
        public string GetQuiz()
        {
            num1 = randNum1.Next(100);
            num2 = randNum2.Next(100);
            // 为计算方便，大数在前小数在后
            //int temp;
            //if (num2 >= num1)
            //{
            //    temp = num1;
            //    num1 = num2;
            //    num2 = temp;
            //}
            operation = randNum1.Next();
            // 0-加法，1-减法，2-乘法，3-除法
            switch (operation%4)
            {
                case 0:
                    question = $"{num1} + {num2} = ";
                    result = num1 + num2;
                    break;
                case 1:
                    question = $"{num1} - {num2} = ";
                    result = num1 - num2;
                    break;
                case 2:
                    question = $"{num1} * {num2} = ";
                    result = num1 * num2;
                    break;
                case 3:
                    // 零不能做分母
                    if (num2 == 0)
                    {
                        num2 = 1;
                    }
                    question = $"{num1} / {num2} = ";
                    result = (double)num1 / num2;
                    break;
            }
            return question;
        }
        public bool CheckAnswer(double answer)
        {
            bool right = Math.Abs(answer - result) < MIN_NUM ? true : false;
            return right;
        }

    }
}
