using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        /*Ratiorg got statues of different sizes as a present from CodeMaster for his birthday, each statue having an non-negative integer size.
         Since he likes to make things perfect, he wants to arrange them from smallest to largest so that each statue will be bigger than the previous one exactly by 1.
         He may need some additional statues to be able to accomplish that. Help him figure out the minimum number of additional statues needed.

        Example

        For statues = [6, 2, 3, 8], the output should be makeArrayConsecutive2(statues) = 3.

        Ratiorg needs statues of sizes 4, 5 and 7.*/
        static void Main(string[] args)
        {
            int[] ar = { 1, 2, 5, 10, 15, 17 };
            int[] ar2 = {1, 3, 5, 6, 7, 8, 10, 30, 50, 46, 99, 101, 102, 32, 35};

            Console.WriteLine(MakeArrayConsecutive(ar));
            Console.WriteLine(MakeArrayConsecutive2(ar));

            Console.WriteLine(MakeArrayConsecutive(ar2));
            Console.WriteLine(MakeArrayConsecutive2(ar2));

        }


        static int MakeArrayConsecutive2(int[] statues)
        {
            int buf;
            for (int i = 0; i < statues.Length - 1; i++)
            {
                for (int j = i + 1; j < statues.Length; j++)
                {
                    if (statues[i] > statues[j])
                    {
                        buf = statues[i];
                        statues[i] = statues[j];
                        statues[j] = buf;
                    }
                }
            }

            int count = 0;
            for (int i = 0; i < statues.Length - 1; i++)
            {
                if (statues[i + 1] - statues[i] != 1)
                    count += statues[i + 1] - statues[i] - 1;
            }

            return count;
        }


        static int MakeArrayConsecutive(int[] statues) => statues.Max() - statues.Min() - statues.Length + 1;
    }
}
