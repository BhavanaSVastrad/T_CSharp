using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_CSharp
{
    internal class ControlStatement
    {
        public static void Main()
        {
            Console.WriteLine("--------CONTROL STATEMENTS--------");
            Controls();
            ControlStatement a= new ControlStatement();
            a.Loops();
        }
        public static void Controls()
        {
            int num;
            Console.WriteLine("Enter the value of num");
          
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd Number");

            }
        }
        public void Loops()
        {
            Console.WriteLine("------Loops-------");
           int  n,sum=0,m;         
           Console.Write("Enter a number: ");      
           n= int.Parse(Console.ReadLine());     
           while(n>0)      
           {      
            m=n%10;      
            sum=sum+m;      
            n=n/10;      
           }      
           Console.Write("Sum is= "+sum);    
         }
    }
}

