using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        /*Below we will define an n-interesting polygon. Your task is to find the area of a polygon for a given n.

        A 1-interesting polygon is just a square with a side of length 1.
        An n-interesting polygon is obtained by taking the n - 1-interesting polygon and appending 1-interesting polygons to its rim, side by side.
        You can see the 1-, 2-, 3- and 4-interesting polygons in the picture below.*/
        static void Main(string[] args)
        {
            Console.WriteLine(ShapeArea(10));
            Console.WriteLine(ShapeArea(1));
            Console.WriteLine(ShapeArea(3));
        }

        static int ShapeArea(int n) => (int) (Math.Pow(n, 2) + Math.Pow(n - 1, 2));
    }
}
