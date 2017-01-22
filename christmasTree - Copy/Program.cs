using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace christmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 0; i--)
            {
                Console.WriteLine((new string(' ', i)) + (new string('*', n - i) + " | " + (new string('*', n - i)) + (new string(' ', i))));
                // Console.WriteLine((new string(' ', i)) + (new string('*', n - i) + " | " + (new string('*', n - i)) + (new string(' ', i)))));
            }

        }
    }
}

