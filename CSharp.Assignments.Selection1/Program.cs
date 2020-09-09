using System;

namespace CSharp.Assignments.Selection1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string inputs="";
            Console.WriteLine("Hello World!");
            inputs = Console.ReadLine();
            if (inputs == null) { Console.WriteLine("ctrl+z pressed "); }
            else { Console.WriteLine("anything else is pressed"); }
        }
    }
}
