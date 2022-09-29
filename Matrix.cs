using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_CSharp
{
    internal class Matrix
    {
        public static void Main()
        {
            Array2daddition();
        }
        public static void Array2daddition()
        {
            Console.WriteLine("---------------Matrix Addition------------");
            Console.Write("Enter Rows: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Columns: ");
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[row, col];
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("Enter First Matrix({0},{1}): ", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            int[,] b = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    
                    Console.Write("Enter Second Matrix({0},{1}): ", i, j);
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            Console.Write("\nThe First matrix is :\n");
            for ( int i = 0; i < row; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < col; j++)
                    Console.Write("{0} ", a[i, j]);
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            Console.Write("\nThe Second matrix is :\n");
            for (int i = 0; i < row; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < col; j++)
                    Console.Write("{0} ", b[i, j]);
            }
         
            int[,] result = new int[row, col];
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("The Addition of two matrix is:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];

                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------");
        }
    }
}
