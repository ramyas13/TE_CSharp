using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TE_CSharp
{
    internal class Program
    {
        public static void Main()
        {
           
            Program e = new Program();
            e.Display(3,"Ramya","developer","ramya@gmail.com");

        }
        public void Display(int eid,string ename,string erole,string email)
        {
            Console.WriteLine("Employee id is:{0}", eid );
            Console.WriteLine("Employee name is:{0}", ename);
            Console.WriteLine("Employee role is:{0}", erole);
            Console.WriteLine("Employee email is:{0}", email);


        }
        
           
            
        
    }
}