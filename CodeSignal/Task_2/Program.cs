using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        /*Given a year, return the century it is in. The first century spans from the year 1 up to and including the year 100, the second - from the year 101 up to and including the year 200, etc.

        Example

        For year = 1905, the output should be centuryFromYear(year) = 20;
        For year = 1700, the output should be centuryFromYear(year) = 17.*/

        static void Main(string[] args)
        {
            Console.WriteLine(CenturyFromYear(2000));
        }
        static int CenturyFromYear(int year)
        {
            return (year % 100 == 0) ? year / 100 : year / 100 + 1;
        }
    }
}
