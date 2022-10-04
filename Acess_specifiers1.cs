using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    /// <summary>
    /// Internal Access Specifiers Demonstration
    /// </summary>
    internal class Rectangle
    {
        internal double length;
        internal double width;

        double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
    internal class Acess_specifiers1
    {
        static void Main(string[] args)
        {
            Rectangle rc = new Rectangle();
            rc.length = 10.35;
            rc.width = 8.3;
            rc.Display();
            Console.ReadLine();
        }
    }
}
        

           