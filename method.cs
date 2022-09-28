using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TE_CSharp
{
    internal class method
    {
        public static void Main(string[] args)
        {
            Display(5);

            method e1 = new method();
            e1.Name("Ramya", "ramya123com");

        }
        public static void Display(int empid)
        {
            Console.WriteLine(empid);

        }
        public void Name(string ename, string email)
        {

            Console.WriteLine(ename + ',' + email);
        }
    }
}
