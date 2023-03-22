using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class FrequencyOfElement
    {
        public static void FrequencyArray()
        {
            int[] arr = { 1, 2, 3, 3, 4, 4, 4, 5, 6, 6, 7, 8, 8, 9 };
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num]++;
                }
                else
                {
                    frequencyMap.Add(num, 1);
                }
            }

            Console.WriteLine("Element\tFrequency");

            foreach (KeyValuePair<int, int> entry in frequencyMap)
            {
                Console.WriteLine(entry.Key + "\t" + entry.Value);
            }
        }
    }
}
