using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_CSharp
{
    public class addition
    {
        public addition(int a, int b)
        {
            Console.WriteLine($"Output in int: {a + b}");
        }
        public addition(float a, float b)
        {
            Console.WriteLine($"Output in float: {a + b}");
        }
        public addition(string a, string b)
        {
            Console.WriteLine($"Output in string: {a + b}");
        }
    }
    internal class Constructoroverloading
    {
        public static void Main()
        {
            addition ad = new addition(10, 8);
            addition ad1 = new addition(18.8f, 2.69f);
            addition ad2 = new addition("13118", "Bhavana");
        }
    }

   
}
