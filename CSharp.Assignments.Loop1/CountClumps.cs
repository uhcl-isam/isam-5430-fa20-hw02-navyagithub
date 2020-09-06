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
    /// simply print out the number that is the count of these clumps.
    /// </summary>
    public class CountClumps
    {
        public static void Main()
        {
            int i ,j,sum=0;
            string h;
            int k=0;
            String atcmd = "AT C5\u001a";

            i = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                String p = Console.ReadLine();
                if (p == atcmd)
                    break;
                j = Convert.ToInt32(p);
                
                if(i==j)
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

            Console.WriteLine(sum);
        }
    }
}
