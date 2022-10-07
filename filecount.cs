using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    internal class filecount
    {
        public static void Main()
        {
            string path = @"C:\Users\EI13043\Documents\SQL\Filecopy.txt";

            //Exists
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("File does not Exist");
            }
            Console.WriteLine("-----------------------------------------");

            //ReadAllLines
            string[] content;
            content = File.ReadAllLines(path);
            Console.WriteLine(content.Length);
            Console.WriteLine("-----------------------------------------");

        }
    }
}
