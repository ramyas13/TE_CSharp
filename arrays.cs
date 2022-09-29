using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class arrays
    {
        public static void Main()
        {
            int[,] x = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6} };


            Console.WriteLine("1st Matrix");
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(" "+x[i, j]);
                }
                Console.WriteLine("\n");
            }
            int[,] y = new int[2, 3] { { 7, 8, 9}, { 10, 11, 12 } };


            Console.WriteLine("2nd matrix");
            for (int i = 0; i < y.GetLength(0); i++)
            {
                for (int j = 0; j < y.GetLength(1); j++)
                {
                    Console.Write(" "+y[i, j]);
                }
                Console.WriteLine("\n");
            }
            int[,] z = new int[2, 3];

            for (int i = 0; i < z.GetLength(0); i++)
            {
                for (int j = 0; j < z.GetLength(1); j++)
                {
                    z[i, j] = x[i, j] + y[i, j];
                }
            }
            Console.WriteLine("The sum is of matrix x and y is");
            for (int i = 0; i < z.GetLength(0); i++)
            {
                for (int j = 0; j < z.GetLength(1); j++)
                {
                    Console.Write(" "+z[i, j]);

                }
                Console.WriteLine("\n");
            }
        }
    }
}
