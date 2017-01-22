using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace axe
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dash = 0;
            var dash2 = n * 3;
            var dash3 = n - 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('-', n*3) + "*" + new string('-', dash) + "*" + new string ('-', n*2 - 2 - dash));
                dash++;
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine(new string('*', n*3 + 1) + new string ('-', n-1) + "*" + new string('-', n - 1));
            }
            if (n>2)
            {
                for (int i = 0; i < n/2 - 1 ; i++)
                {
                    Console.WriteLine( new string ('-', dash2) + "*" + new string('-', dash3) + "*" + new string('-', n * 5 - 2 - dash2 - dash3));
                    dash2--;
                    dash3 += 2;
                }
                if (n % 2 != 0)
                {
                    Console.WriteLine(new string('-', dash2 ) + new string('*', n*2 - 2) + new string('-', n/2 + 1));
                }
                else
                {
                    Console.WriteLine(new string('-', dash2) + new string('*', n*2 - 1 ) + new string('-', n/2));
                }
                
                
            }
            else
            {
                Console.WriteLine(new string('-', n*3) + new string('*', n+1) + "-");
            }
            
        }
    }
}
