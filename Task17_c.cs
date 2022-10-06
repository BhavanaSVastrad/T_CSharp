using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_CSharp
{
    public class Task17_c
    {
        public static void Main()
        {
            string[] content;
            content = File.ReadAllLines(@"C:\Users\ei13118\Task17_a.txt");
            Console.WriteLine(content[0]);
        }
    }
}