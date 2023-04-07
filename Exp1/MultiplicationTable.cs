using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp1
{
    internal class MultiplicationTable
    {
        public void ShowTable()
        {
            int i, j, k;
            for (i = 1; i <= 9; i++)
            {
                for (j = i, k = 1; k <= (10 - i); j++, k++)
                {
                    System.Console.Write($"{i} * {j} = {i * j, 2}  ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
