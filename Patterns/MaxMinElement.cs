using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class MaxMinElement
    {
        public static void MaxMinElementArray()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int max = arr[0];
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                else if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine("Maximum element in the array: " + max);
            Console.WriteLine("Minimum element in the array: " + min);
        }
    }
}
