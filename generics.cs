using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class generics
    {
        // Declare Generic Delegate
        public delegate T SampleDelegate<T>(T a,T b);
        class Area
        {
            public int Square(int a,int b)
            {
                return a*b;
            }
            public int Cube(int c,int d)
            {
                return 6*(c*d);
            }
            public double Circle(double r,double pi)
            {
               
                return pi*(r*r);

            }
 
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("****Generic Delegate Example****");
                Area m = new Area();
                // Instantiate delegate with Square method using int
                SampleDelegate<int> dlgt = new SampleDelegate<int>(m.Square);
                Console.WriteLine("Area of the Square: " + dlgt(5,5));
                // Instantiate delegate with Cube method
                dlgt = m.Cube;
                Console.WriteLine("Area of Cube: " + dlgt(9,9));
                // Instantiate delegate with Circle method using double
                SampleDelegate<double> dlgt1 = new SampleDelegate<double>(m.Circle);
                Console.WriteLine("Area of the circle: " + dlgt1(5,3.14));

            }
        }
    }
}

