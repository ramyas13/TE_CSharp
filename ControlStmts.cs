using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class ControlStmts
    {
        public static void Main()
        {
            Console.WriteLine("CONTROL STATEMENTS");
            ifstate();
            ControlStmts c = new ControlStmts();
            c.forloop();

        }
        public static void ifstate()
        {
            Console.WriteLine("IF Statement");
            int x;
            Console.WriteLine("Enter the value");
            x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("x is Even ");
            }
            else
            {
                Console.WriteLine("x is odd");
            }

        }
        public void forloop()
        {
            Console.WriteLine("For Loop");
            int[] n = { 1, 2, 3 };
            int sum = 0;
            Console.WriteLine("----------------------------------------");
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }
            Console.WriteLine("----------------------------------------");
            for (int i = 0; i < n.Length; i++)
            {
                sum = sum + n[i];
            }
            Console.WriteLine("Sum is:{0}", sum);
           
        }
    }
}
            
