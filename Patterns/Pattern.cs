using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Pattern
    {
        public static void ReactangleReverse()
        {
            Console.WriteLine("Enter The * num input");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        public static void PrintReactangle()
        {
            /* Input numbers for length and width to construct rectangle or square. */
            int length = 7, width = 7;
            Console.Write(" ");

            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= length; j++)
                {
                    if (i == 1 || i == width || j == 1 || j == length)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n ");
            }
        }
    }
}
