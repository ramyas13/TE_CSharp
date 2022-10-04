using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    /// <summary>
    /// Public access specifiers
    /// </summary>
    class PublicAccess
    {
        public string msg = "This variable is public";
        public void disp(string msg)
        {
            Console.WriteLine("This function is public : " + msg);
        }
    }
    internal class public_AccessSpecifier
    {
        static void Main(string[] args)
        {
            PublicAccess pAccess = new PublicAccess();
            Console.WriteLine(pAccess.msg); // Accessing public variable
            pAccess.disp("Hello !!"); // Accessing public function
        }
    }

}
