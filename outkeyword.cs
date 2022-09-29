using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_CSharp
{
    internal class outkeyword
    {
        public static void Main()
        {
            int id;
            string name, dept;
            studentdetails(out id, out name, out dept);
            Console.WriteLine("------Display Student Details using out keyword-----\n");
            Console.WriteLine($"Student ID: {id}");
            Console.WriteLine($"Student Name: {name}");
            Console.WriteLine($"Student Department: {dept} \n");
            Console.WriteLine("-----------------------------------------------------");

        }
        public static void studentdetails(out int sid, out string sname, out string sdept)
        {
            sid = 100;
            sname = "BHAVANA S VASTRAD";
            sdept = "COMPUTER SCIENCE ENGINEERING";
        }
    }
}
