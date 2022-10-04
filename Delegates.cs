using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public delegate void Bankdetailsdelegate(string Bankname, string Interest_rate);

    /// Multi-cast delegate working - hold the reference of more than one method
    public class Bank
    {
        public void Bank1(string Bankname, string Interest_rate)
        {
            Console.WriteLine($"{Bankname}:{Interest_rate}");
        }
        public void Bank2(string Bankname, string Interest_rate)
        {

            Console.WriteLine($"{Bankname}:{Interest_rate}");
        }
        public void Bank3(string Bankname, string Interest_rate)
        {
            
           Console.WriteLine($"{Bankname}:{Interest_rate}");
        }
        public void Bank4(string Bankname, string Interest_rate)
        {

            Console.WriteLine($"{Bankname}:{Interest_rate}");
        }
        public void Bank5(string Bankname, string Interest_rate)
        {

            Console.WriteLine($"{Bankname}:{Interest_rate}");
        }
        
    }

    /// <summary>
    /// Access the methods through delegates
    /// </summary>
    internal class Delegates
    {
        public static void Main()
        {
            Bank bank = new Bank();


            Bankdetailsdelegate bankdetailsdelegate = bank.Bank1;
            Console.WriteLine("Bank Name:Interest Rate");
            bankdetailsdelegate("SBI","2.70%" );
            bankdetailsdelegate -= bank.Bank2;
            bankdetailsdelegate("Kotak Mahindra ", "3.00%-3.50%");
            bankdetailsdelegate -= bank.Bank3;
            bankdetailsdelegate("HDFC Bank", "3.50%");
            bankdetailsdelegate -= bank.Bank4;
            bankdetailsdelegate("Axis Bank", "3.00%-3.50%");
            bankdetailsdelegate -= bank.Bank5;
            bankdetailsdelegate("ICICI Bank", "3.00%-3.50%");


        }

    }
}
