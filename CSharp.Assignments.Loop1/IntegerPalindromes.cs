
using System;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// A palindrome is a sequence of characters that reads the same backward
    /// as forward. For example, each of the following five-digit integers
    /// is a palindrome: 12321, 55555, 45554 and 11611. 
    /// Write an app that reads in exactly 9-digit positive integers 
    /// and determines whether it’s a palindrome (display either:
    /// "a palindrome" or "not a palindrome"). If the number is not 
    /// nine digits long, display an error message and allow the user to
    /// enter a new value. </summary>
    /// <remark>[Hint: Use the remainder and division operators to pick off
    /// the number’s digits one at a time, from right to left.]</remark>
    /// 
    public class IntegerPalindromes
    {
        public static void Main()
        {
            // enter sentinel inputs
            // then check the palindrome only once.
            while (true)
            {
                //Console.WriteLine("Enter a number");

                String input = Console.ReadLine();
                if (input == null)
                {
                    
                    break;
                }
                int i = Convert.ToInt32(input);

                int j,k,num,rem,sum;
                k = i;
                j = 0;
                num = i;
                sum = 0;
               // Console.WriteLine("Step1");
                while (k >0)
                {
                   // Console.WriteLine("Step2");
                    k = k / 10;
                    j++;
                }
                if (j != 9)
                {
                    Console.WriteLine("Enter a palindrome");
                }
                else
                {
                    while (num > 0)
                    {
                        rem = num % 10; //for getting remainder by dividing with 10    
                        num = num / 10; //for getting quotient by dividing with 10    
                        sum = sum * 10 + rem;
                    }
                    if (sum == i)
                        Console.WriteLine("a palindrome");
                    else
                    {
                        Console.WriteLine("Not Palindrome");
                    }
                }

            }



        }
    }
}
