using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class SumOfAllDigit
    {
        public static void sum()
        {
            int num = 12345;
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                sum += digit;
                num /= 10;
            }

            Console.WriteLine("Sum of digits: " + sum);
        }
    }
}
