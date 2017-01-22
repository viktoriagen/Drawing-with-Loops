using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = 10;
            var symbolsPerRow = 10;

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(new string('*', symbolsPerRow));
            }
        }
    }
}
