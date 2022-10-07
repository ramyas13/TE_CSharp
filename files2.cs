using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class File_demo
    {
        public  void MoveFiles()
        {
            string source = @"C:\Users\EI13043\Documents\C_Sharp\files2.txt";
            string target = @"C:\Users\EI13043\Documents\SQL\files2.txt";
            File.Move(source, target);
        }
        public void CopyFiles()
        {
            string source = @"C:\Users\EI13043\Documents\C_Sharp\Filecopy.txt";
            string target = @"C:\Users\EI13043\Documents\SQL\Filecopy.txt";
            File.Copy(source, target);
        }
        public void Deletefiles()
        {
            File.Delete(@"C:\Users\EI13043\Documents\C_Sharp\Filecopy.txt");
        }
   
    }
    internal class files2
    {

       
        public static void Main()
        {
            File_demo n = new File_demo();
            //n.MoveFiles();
            //n.CopyFiles();
            n.Deletefiles();
            
        }
    }
}
