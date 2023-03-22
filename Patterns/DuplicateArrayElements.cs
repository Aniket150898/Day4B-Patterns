using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class DuplicateArrayElements
    {
        public static void Duplicate()
        {

            Console.WriteLine("Counting a total number of duplicate elements in an Array");
            int[] arr = { 1, 2, 3, 3, 4, 4, 4, 5, 6, 6, 7, 8, 8, 9 };
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            Console.WriteLine("\nTotal number of duplicate elements in the array: " + count);
        }
    }
}
