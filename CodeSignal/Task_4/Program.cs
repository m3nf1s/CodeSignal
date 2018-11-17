using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        /*Given an array of integers, find the pair of adjacent elements that has the largest product and return that product.

        Example

        For inputArray = [3, 6, -2, -5, 7, 3], the output should be adjacentElementsProduct(inputArray) = 21.
        7 and 3 produce the largest product.*/
        static void Main(string[] args)
        {
            int[] array = { 3, 6, -2, -5, 7, 3 };
            Console.WriteLine(AdjacentElementsProduct(array));
        }

        static int AdjacentElementsProduct(int[] inputArray)
        {
            int max = inputArray[0] * inputArray[1];
            for (int i = 1; i < inputArray.Length - 1; i++)
            {
                int currentMulti = inputArray[i] * inputArray[i + 1];
                if (max < currentMulti) max = currentMulti;
            }

            return max;
        }
    }
}
