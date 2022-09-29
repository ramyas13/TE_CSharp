using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class paramarray
    {
        public static void Main()
        {
            int result = product(1,2,3);
            Console.WriteLine(result);
            Console.WriteLine("---------------------------------");
            int[] n1 = new int[] { 2,4,5,6,7 };
            int t = product(n1);
            Console.WriteLine(t);
        }
        /// <summary>
        /// method with the working of params keyword
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int product(params int[] n)
        {
            int product=1;
            foreach (int i in n)
            {
                product =product * i;
            }
            return product; 

        }

    }
}
