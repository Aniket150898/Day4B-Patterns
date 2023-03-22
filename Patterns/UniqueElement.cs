using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class UniqueElement
    {
        public static void Unique()
        {
            int[] arr = { 1, 2, 3, 3, 4, 4, 4, 5, 6, 6, 7, 8, 8, 9 };
            Console.Write("Unique elements in the array: ");
           
            for (int i = 0; i < arr.Length; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
