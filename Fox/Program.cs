using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int n2 = n / 2;
            int a = n;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('*',i) + "\\" + new string ('-', ((n*2 +3) - 2 - 2*i )) + "/" + new string('*', i));
            }
            for (int i = 1; i <= n/3; i++)
            {

                Console.WriteLine( "|" + new string('*', n2) + "\\" + new string('*',a) + "/" + new string('*', n2) + "|");
                n2++;
                a -= 2;
            }
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('-', i) + "\\" + new string('*', ((n * 2 + 3) - 2 - 2 * i)) + "/" + new string('-', i));
            }
        }
    }
}
