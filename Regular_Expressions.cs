using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TE_CSharp
{
    /// <summary>
    /// Regular Expression - using System.Text.RegularExpressions;
    /// </summary>
    internal class Regular_Expressions
    {
        public static void Main()
        {
            mob_no();
        }

        public static void mob_no()
        {
            Console.WriteLine("Mobile Number Validation");
            string mobile = "8380337727";
            var validate_mobile = Regex.IsMatch(mobile, @"^\(?([7-8]{1}[0-9]{9})");
            Console.WriteLine(validate_mobile);
        }
    }
}
