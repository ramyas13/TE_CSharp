using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Enumeration
    {
        enum Program
        {
            CSharp,
            C = 6,
            Java = 10,
            Python = -3,
            Kotlin,
            JavaScript
        }
        public static void Main()
        {
            Console.WriteLine(Program.CSharp);
            int c = (int)Program.C;
            Console.WriteLine(c);
            var j = (Program)10;
            Console.WriteLine(j);
            int python = (int)Program.Python;
            Console.WriteLine(python);
        }
    }
}
