using System;
using static System.Console;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Develop a C# app that will determine whether any of several
    /// department-store customers has exceeded the credit limit on a charge
    /// account. For each customer, the following facts are available:
    ///    1) account number,
    ///    2) balance at the beginning of the month,
    ///    3) total of all items charged by the customer this month,
    ///    4) total of all credits applied to the customer’s account this month and,
    ///    5) allowed credit limit.
    /// The app should input all these facts as integers,
    /// calculate the new balance(= beginning balance + charges – credits),
    /// display the new balance and determine whether the new balance exceeds
    /// the customer’s credit limit.
    /// For those whose credit limit is exceeded, 
    /// the app should display the message "Credit limit exceeded" on a separate line. 
    /// Use sentinel-controlled iteration to obtain the data for each account
    /// (e.g. the iteration will terminate if the account number is a
    /// negative number).
    /// </summary>
    public class CreditLimitCalculator
    {
        public static void Main()
        {
            //Console.WriteLine("Hello");
            // read in account number
            // Enter your sentinel loop here
            int acctnum, bbg, charge, ttcredit, credlmt, newbl;

            while (true)
            {
                acctnum = Convert.ToInt32(Console.ReadLine());
                if (acctnum < 0)
                {

                    break;

                }
                //123456, 1000, 451, 523, 3000
               /* 123456, 1000, 451, 523, 3000,
                        777777, 1234, 2123, 1744, 1500,
                        1854332, 43, 123, 111, 54,
                        1775434, 43, 123, 111, 55,
                        -1, 43, 123, 111, 60, // sentinel
                        -1, 43, 123, 111, 60*/

                bbg = Convert.ToInt32(Console.ReadLine());

                charge = Convert.ToInt32(Console.ReadLine());
                ttcredit = Convert.ToInt32(Console.ReadLine());
                credlmt = Convert.ToInt32(Console.ReadLine());

                

                newbl = bbg + charge - ttcredit;
                Console.WriteLine(newbl);
                if (newbl>credlmt)
                {
                    
                    Console.WriteLine("Credit limit exceeded");
                }
                


            }






            }
    }
}
