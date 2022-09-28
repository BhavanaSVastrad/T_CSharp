using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_CSharp
{
    internal class Task12_1
    {
        
            public static void Main()
            {
                Console.WriteLine("Static and Instance Methods\n");


            Condtitional();
            Task12_1 c = new Task12_1();
                c.Instance();
            
        }
            /// <summary>
            /// STATIC METHODS - INVOKED ONCE
            /// </summary>
            public static void Condtitional()
            {
                Console.WriteLine("STATIC METHOD");
              
               
                Console.WriteLine("Invoked from static method\n");
             

            }
            /// <summary>
            /// INSTANCE METHOD - no static keyword
            /// </summary>
            public void Instance()
            {
                Console.WriteLine("INSTANCE METHOD");

                Console.WriteLine("Invoked from instance method");

        }
        }
    }

