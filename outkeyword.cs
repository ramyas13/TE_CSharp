using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class outkeyword
    {
        public static void Main()
        {
            int sid;
            string sname;
            string sdep;
            Student(out sid, out sname, out sdep);
            Console.WriteLine("Student id is:{0} ",sid);
            Console.WriteLine("Student Name is:{0} ", sname);
            Console.WriteLine("Student Department is:{0}", sdep);


        }
        public static void Student(out int id,out string name,out string department)
        {
            id = 2;
            name = "Sowmya";
            department = "CSE";


        }

    }   
}
