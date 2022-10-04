using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TE_CSharp
{
    /// <summary>
    /// Parent class with protected variables
    /// </summary>
    public class Bonus
    {
        protected int bonus=3000;

    }
    /// <summary>
    /// Child class - can access the protected variables - Single
    /// </summary>
    public class staff : Bonus
    {
        protected int salary;
        protected void bonus1()
        {
            salary = 3 * bonus;
            Console.WriteLine($"Bonus for Staff is {salary} ");
            
            
           
        }
    }
    public class Nonstaff : staff
    {
        protected int salary1;
        public void bonus2()
        {
            Console.WriteLine($"Bonus is {bonus} ");
            salary1 = 2 * bonus;
            Console.WriteLine($"Bonus for NonStaff is {salary1} ");
            bonus1();
        }
    }
    internal class Inheritance
    {
        public static void Main()
        {
           
            Nonstaff n = new Nonstaff();
            n.bonus2();
        }
    }
}



        


    



        

