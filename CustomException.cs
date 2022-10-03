using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// User-defined exception -> ApplicationException/Exception
/// </summary>
namespace TE_CSharp
{
    /// <summary>
    /// Step 1 :Create the user-defined exception class
    /// </summary>
    public class AgeException : ApplicationException
    {
        //Constructor 
        public AgeException(string message) : base(message)
        {

        }
    }
    /// <summary>
    /// Step 2:Implementing the exception in the try and catch block
    /// </summary>
    internal class CustomException
    {
        public static void Main()
        {
            int age;
            try
            {
                Console.WriteLine("Enter the Age");
                age = Convert.ToInt32(Console.ReadLine());
                if (age > 22)
                {
                    throw (new AgeException("Valid Age"));
                }
                else
                {
                    Console.WriteLine("Age not Valid");
                }
            }
            catch (AgeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}