using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_CSharp
{
    internal class Task17_b
    {
        public static void Main()
        {
            //move
            
            string source = @"C:\Users\ei13118\Task17_a.txt";
            string destination = @"C:\Users\ei13118\Task17_a.txt";
            File.Move(source, destination);
            File.Move(@"C:\Users\ei13118\Task17_a.txt", @"C:\Users\ei13118\Task17_b(1).txt");
            

            //copy
            /*
            string source_path = @"C:\Users\ei13072\Documents\C#\filemult.txt";
            string dest_path = @"C:\Users\ei13072\Documents\C#\File\filemult.txt";
            File.Copy(source_path, dest_path);
            */

            //delete
            string path = @"C:\Users\ei13118\Task17_b.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
                try
                {
                    File.Delete(path);
                }
                catch
                {
                    Console.WriteLine("Not Happening!");
                }
            }
            else
            {
                Console.WriteLine("File does not Exist");
            }
        }
    }
}