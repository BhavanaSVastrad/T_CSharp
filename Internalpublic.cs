using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_CSharp
{
    public class Internal
    {
        public string ename;

        public void std_details(string name)
        {
            ename = name;
            Console.WriteLine($"{ename}");
        }
    }
    public class Internalpublic
    {
        public static void Main()
        {
            Internal i = new Internal();
            i.std_details("Bhavana");
        }
    }
}
