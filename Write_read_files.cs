using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{

    public class Files_Demo
    {
        /// <summary>
        /// Write contents into the file using StreamWriter class
        /// </summary>
        public void Write()
        {
            FileInfo fileInfo = new FileInfo(@"C:\Users\EI13043\Documents\C_Sharp\files1");
            FileStream fs = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    sw.WriteLine("Multiplication Table of " + i);
                    for (int j = 1; j <= 10; j++)
                    {
                        sw.WriteLine("{0} X {1}= {2} \n", i, j, i * j);

                    }
                }

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                sw.Close();
                fs.Close();
            }
        }
        public void read()
        {

            //Specify the filename and the path of the file to be created 
            //Fileinfo - class
            FileInfo fileInfo = new FileInfo(@"C:\Users\EI13043\Documents\C_Sharp\files1");
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader reader = new StreamReader(fileStream);
            try
            {
                string contents = reader.ReadToEnd();
                Console.WriteLine(contents);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                reader.Close();
                fileStream.Close();
            }

        }
    }
    internal class Write_read_files
    {
        public static void Main()
        {
            Files_Demo demo = new Files_Demo();
            demo.Write();
            demo.read();
        }
    }
}
