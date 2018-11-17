using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        /*Write a function that returns the sum of two numbers.

        Example

        For param1 = 1 and param2 = 2, the output should be add(param1, param2) = 3.*/
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 3));
            Console.ReadLine();
        }

        static int Add(int param1, int param2) => param1 + param2;
    }
}
