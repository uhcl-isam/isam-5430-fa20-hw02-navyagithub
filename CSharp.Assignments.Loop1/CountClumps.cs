using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Create an app that lets you enter a bunc hof integers until the
    /// end of line with a CTRL-Z. We will say that a "clump" of these numbers
    /// is a series of 2 or more adjacent elements of the same value. The app will
    /// 
    /// 
    /// simply print out the number that is the count of these clumps.
    /// </summary>
    /// 

    public class CountClumps
    {
        public static void Main()
        {
            int i ,j,sum=0;
            string input,n;
            int k=0;
            //String atcmd = "AT C5\u001a" ;
            input = Console.ReadLine();

            if (input == null)
            {
                Console.WriteLine("CTRLZ has been pressed");
                sum = 0;
            }
            else
            {
                i = Convert.ToInt32(input);
                while (true)
                {
                    n = Console.ReadLine();
                    if (n == null)
                    {
                        Console.WriteLine("CTRLZ has been pressed");
                        
                        break;
                    }
                    else
                    {

                        j = Convert.ToInt32(n);

                        if (i == j)
                        {
                            if (k == 0)
                            {
                                sum++;
                                k++;
                            }
                        }
                        else
                        {

                            k = 0;

                        }
                        i = j;
                    }
                }
            }

                Console.WriteLine(sum);
            
        }
    }
}
