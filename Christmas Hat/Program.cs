using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string indent = "*.";

            Console.WriteLine(new string('.', ((4 * n + 1) - 3) / 2) + "/|\\" + new string('.', ((4 * n + 1) - 3) / 2));
            Console.WriteLine(new string('.', ((4 * n + 1) - 3) / 2) + "\\|/" + new string('.', ((4 * n + 1) - 3) / 2));
            for (int i = 0; i < 2*n; i++)
            {
                Console.WriteLine(new string('.', (((4 * n + 1) - 3 - (2 * i)))/2) + "*" + new string('-', i) + "*" + new string('-', i) + "*" + new string('.', (((4 * n + 1) - 3 - (2 * i))) / 2));
            }
            Console.WriteLine(new string('*', 4 * n + 1));
            Console.WriteLine(string.Concat(Enumerable.Repeat(indent, (4 * n + 1)/2)) + "*");
            Console.WriteLine(new string('*', 4 * n + 1));


        }
    }
}
//коледна шапка с ширина 4 * n + 1 колони 
//височина 2 * n + 5 реда
