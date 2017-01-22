using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int asterixCount = 1;

            int rows = (2 * n) - 1;

            for (var Currrow = 0; Currrow <= rows; Currrow++)
            {
                int emtySpasesCount = n - asterixCount;
                Console.Write(new string (' ', emtySpasesCount) );

                for (int currAs = 0; currAs < asterixCount; currAs++)
                {
                    Console.Write(" *");
                }
                if (Currrow < n - 1)
                {
                    asterixCount++;
                }
                else
                {
                    asterixCount--;
                }
                
                Console.WriteLine();
            }
          
            }

        }
    }

