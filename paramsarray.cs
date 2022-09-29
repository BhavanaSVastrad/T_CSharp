using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_CSharp
{
    internal class paramsarray
    {
        public static int Multiplication(params int[] numbers)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Multiplication Table of " + i);
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("\n{0} X {1}= {2} \n", i, j, i * j);

                }
            }
            return (0);

        }
        public static void Main()
        {
            int m = Multiplication(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.ReadLine();
        }
    }
}
