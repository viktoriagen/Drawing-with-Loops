using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_with_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n == 2)
            {
                Console.WriteLine("%%%%");
                Console.WriteLine("%**%");
                Console.WriteLine("%%%%");
            }
            else if (n % 2 == 0)
            {
                Console.WriteLine(new string('%', 2 * n));
                for (int i = 1; i <= n  - 2; i++)
                   
                {
                    if (i == n / 2)
                    {
                        Console.WriteLine("%" + new string(' ', n - 2) + "**" + new string(' ', n - 2) + "%");

                    }
                    Console.WriteLine("%" + new string(' ', 2 * n - 2) + "%");
                }
                Console.WriteLine(new string('%', 2 * n));
            }
            else
            {
                Console.WriteLine(new string('%', 2 * n));
                for (int i = 1; i <= n -1   ; i++)
                {
                    if (i == n / 2 + 1)
                    {
                        Console.WriteLine("%" + new string(' ', n - 2) + "**" + new string(' ', n - 2) + "%");

                    }
                    Console.WriteLine("%" + new string(' ', 2 * n - 2) + "%");
                }
                Console.WriteLine(new string('%', 2 * n));
            }
        }
    }
}
