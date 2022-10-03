using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class Exception
    { 
        /// <summary>
        /// Multiple catch blocks
        /// </summary>
        public void MultipleCatch()
        {
            int[] a = { 2, 8, 6, 4, 8, 2 };
            int[] b = { 0, 2, 2, 0, 4 };
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
            public void ArrayIndex()
            {
                try
                {
                    int[] num = { 1, 2, 3 };
                    Console.WriteLine(num[10]);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Index out of range");
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.Source);
                    Console.WriteLine(e.StackTrace);
                    Console.WriteLine(e.TargetSite);
                }
            }

    }

    internal class Exceptions
    {
        public static void Main()
        {
            Exception ex = new Exception();
           
            ex.MultipleCatch();
            Console.WriteLine("-------------------------------------------");
            ex.ArrayIndex();
        }
    }
}
