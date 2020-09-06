using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Create an application that reads a bunch of non-negative integers line-by-line until a negative integer or the end-of-line (CTRL-Z) has reached. The app will print out the sum of all the fillers that will make all the values entered so far will appear in increasing order, where each value is larger than the previous number. That is each filler is added to each input, such that the numbers will all appear in increasing order (e.g. 1, 2, 3, 10). The only exception is when the element is 0, where the current number and the subsequent numbers will restart from zero.
    /// </summary>
    /// <param name="a"></param>
    /// <remarks>In essence, this app will calculate the sum of all these values added to the original numbers such that our projected numbers will appear in increasing order.</remarks>
    /// <returns>The sum of all the fillers</returns>
    public class AscendingFillers
    {
        public static void Main()
        {

            int i, j,sum = 0;
           
           
            //Console.WriteLine("Enter the list of numbers:");
            i = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                
               
                if (i < 0)
                    break;
                j = Convert.ToInt32(Console.ReadLine());
                if (j >= 0)
                {
                    if (j < i && j!=0 )
                    {
                        sum = sum + (i - j) + 1;
                        i = j + (i - j) + 1;
                    }
                    else if(j==i && j!=0)
                    {
                        sum = sum + 1;
                        i = j + 1;
                    }
                 
                    else
                    {
                        i = j;
                    }
                }
                else
                    break;
            
     
               // Console.WriteLine("sum"+sum);


            }

            Console.WriteLine("sum is" + sum);

        }
    }
}
