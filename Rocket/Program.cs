using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var space = 0;
            var dot = n/2;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string ('.', (n*3 - 2 - space)/2) + "/" + new string(' ', space) + "\\" + new string ('.', (n * 3 - 2 - space) / 2));
                space += 2;
            }
            Console.WriteLine( new string('.', n/2) + new string('*', n*2) + new string('.', n / 2));

            for (int i = 0; i < 2*n; i++)
            {
                Console.WriteLine(new string('.', n / 2) + "|" + new string ('\\', n*2 - 2) + "|" + new string('.', n / 2));
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine(new string ('.', dot) + "/" + new string ('*', n*3 - 2 - (2*dot)) + "\\" + new string('.', dot));
                dot--;
            }
        }
    }
}
