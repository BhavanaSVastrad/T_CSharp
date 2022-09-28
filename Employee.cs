using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_CSharp
{
    internal class Employee
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Welcome----------\n");
            employee_details();
        }
        public static void employee_details()
        {
            int empid;
            int n;
            string empname;
            Console.WriteLine("Enter the number of employees:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the Employee ID: ");
                empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Employee Name: ");
                empname = Console.ReadLine();
                Employee e = new Employee();
                e.display(empid, empname);
                Console.WriteLine();
            }
        }
        public void display(int empid, string empname)
        {
            Console.WriteLine("Employee Details are: ");
            Console.WriteLine("Employee Id:" +empid);
            Console.WriteLine("Employee name:"+empname);

        }
    }
}

