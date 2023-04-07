using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StarsGraph starsGraph = new StarsGraph();
            starsGraph.ShowStarightTriangle();
            System.Console.WriteLine();
            starsGraph.ShowReversedTriangle();
            System.Console.WriteLine();
            starsGraph.ShowRhombus();
            System.Console.WriteLine();

            MultiplicationTable multiplicationTable = new MultiplicationTable();
            multiplicationTable.ShowTable();
        }
    }
}
