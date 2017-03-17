using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;

            while (true)
            {
                Console.WriteLine("Type a number and I'll do ");
                Console.WriteLine("nothing at all with it.");
                Console.WriteLine("Type q to quit.");
                s = Console.ReadLine();
                if (s == "q")
                {
                    System.Environment.Exit(1);
                }
            }
        }
    }
}
