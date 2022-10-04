using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_CSharp
{

    public class UserValidate : ApplicationException
    {
        
        public UserValidate(string message) : base(message)
        {

        }
    }
  
    internal class Validation
    {
        public static void Main()
        {
            int total_trainees;
           
            Console.WriteLine("-----User Defined Validation-----");
           
            try
            {
                Console.WriteLine("Enter Your age");
                total_trainees = Convert.ToInt32(Console.ReadLine());
                if (total_trainees < 22)
                {
                    throw (new UserValidate("You are not eligible "));
                }
                else
                {
                    Console.WriteLine("You are Eligible");
                }
            }
            catch (UserValidate e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}