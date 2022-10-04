using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{

    public class Add
    {
        public int x, y;
        public float p, q;
        public string m, n;

        /// <summary>
        /// Constructor overloaded with one parameter
        /// </summary>
        public Add(int abc, int def)
        {
            this.x = abc;
            this.y = def;
            Console.WriteLine($"The integers are {abc} and {def}");

        }
        public Add(float pqr,float xyz)
        {
            this.p = pqr;
            this.q = xyz;
            Console.WriteLine($"The floating values are {pqr} and {xyz}");
        }
        public Add(string mno, string rst)
        {
            this.m = mno;
            this.n = rst;
            Console.WriteLine($"The string values are {mno} and {rst}");
        }

        internal class Constructor_overloading
        {
            public static void Main()
            {
                Add a = new Add(2, 3);
                Add a1 = new Add(1.2f, 2.5f);
                Add a3 = new Add("string1", "string2");
            }
        }
    }
}
