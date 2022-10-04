using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_CSharp
{
    public class task15
    {
        

      
        public void MultipleCatch()
        {
            int[] a = { 10, 8, 6, 4, 8, 2 };
            int[] b = { 5, 0, 3, 0, 2 };
            for (int i = 0; i < a.Length; i++)
            {
                try
                {
                    Console.WriteLine(a[i] / b[i]);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }

            }

        }

    }

    internal class Exception
    {
        public static void Main()
        {
            task15 ex = new task15();
         
            Console.WriteLine("----------Multiple-Catch-----------");
           
            ex.MultipleCatch();
        }
    }
}