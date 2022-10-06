using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_CSharp
{
    internal class Task17_d
    {
        public static void Main(string[] args)
        {
            int counter = 0;
            foreach (string line in File.ReadLines(@"C:\Users\ei13118\Task17_a.txt"))
            {
                Console.WriteLine(line);
                counter++;
            }
            Console.WriteLine("There are {0} lines", counter);
        }
    }
}