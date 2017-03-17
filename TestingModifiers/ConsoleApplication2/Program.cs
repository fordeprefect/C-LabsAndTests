using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 6;
            b = a++;
            Console.WriteLine(++b);
            Console.ReadLine();
            

            int x = 15;
            int y = 6;
            x %= y;
            Console.WriteLine(x);
            Console.ReadLine();
          
        }
    }
}
