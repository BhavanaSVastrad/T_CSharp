using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_CSharp
{
    public class File_ReadWrite
    {
        //Create and store
        public void Write()
        {

            FileInfo fileInfo = new FileInfo(@"C:\Users\EI13118\Task17_a.txt");
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter writer = new StreamWriter(fileStream);
            try
            {
                writer.WriteLine("2 x 1 = 2\r\n2 x 2 = 4\r\n2 x 3 = 6\r\n2 x 4 = 8\r\n2 x 5 = 10\r\n2 x 6 = 12\r\n2 x 7 = 14\r\n2 x 8 = 16\r\n2 x 9 = 18\r\n2 x 10 = 20");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                writer.Close();
                fileStream.Close();
            }

        }
        //  Read 
        public void read()
        {

            //Specify the filename and the path of the file to be created 
            //Fileinfo - class
            FileInfo fileInfo = new FileInfo(@"C:\Users\EI13118\Task17_a.txt");
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader reader = new StreamReader(fileStream);
            try
            {
                string contents = reader.ReadToEnd();
                Console.WriteLine(contents);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                reader.Close();
                fileStream.Close();
            }

        }
    }
    internal class Task_17_a
    {
        public static void Main()
        {
            File_ReadWrite rw = new File_ReadWrite();
            rw.Write();
            //rw.read();


            //Move
            //File.Move(@"C:\Users\EI13141\sample.txt", @"C:\Users\EI13141\source\sample.txt");

            //Copy
            string path = @"C:\Users\EI13118\Task17_a.txt";
            //string destination = @"C:\Users\EI13141\c_sample.txt";
            //File.Copy(path, destination);

            //Delete files
            //File.Delete(path);

            //Read First line from the file
            string[] content;
            content = File.ReadAllLines(path);
            Console.WriteLine(content[0]);
            Console.WriteLine(content[1]);

            var lineCount = File.ReadLines(@"C:\Users\EI13118\Task17_a.txt").Count();
            Console.WriteLine(lineCount);


        }
    }
}