using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_CSharp
{
    internal class Enumeration
    {
        enum Weekdays
        {
            Sunday = 1,
           Monday =2,

           Tuesday=3,
           Wednesday=4,
           Thursday=5,
           Friday=6,
           Saturday=7,
        
        }
        public static void Main()
        {
            Console.WriteLine(Weekdays.Monday);
            int methods = (int)Weekdays.Tuesday;
            Console.WriteLine(methods);
            var del = (Weekdays)3;
            Console.WriteLine(del);
            Console.WriteLine(del+" is "+methods+" nd day of the week");


        }
       
    }
}
