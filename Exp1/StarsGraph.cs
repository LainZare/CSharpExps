namespace Exp1
{
    internal class StarsGraph
    {
        public void ShowStarightTriangle ()
        {
            int rows = 6;
            int i = 1, j = 1;
            for (;i <= rows; i++)
            {
                for (j = (rows-i); j > 0; j--)
                {
                    System.Console.Write(" ");
                }

                for (j = i; j > 0; j--)
                {
                    System.Console.Write("* ");
                }
                System.Console.WriteLine();
            }
        }
        public void ShowReversedTriangle()
        {
            int rows = 6;
            int i = rows, j = rows;
            for (; i > 0; i--)
            {
                for (j = (rows-i); j > 0; j--)
                {
                    System.Console.Write(" ");
                }

                for (j = i; j > 0; j--)
                {
                    System.Console.Write("* ");
                }
                System.Console.WriteLine();
            }
        }
        public void ShowRhombus()
        {
            this.ShowStarightTriangle();
            for (int i = 7; i > 0; i--)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
            this.ShowReversedTriangle();
        }
    }
}
