using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class ReverseWord
    {
        public static void ReverseEachWord()
        { 
                string str = "Hello World";
                string[] words = str.Split(' ');

                for (int i = 0; i < words.Length; i++)
                {
                    char[] letters = words[i].ToCharArray();
                    Array.Reverse(letters);
                    words[i] = new string(letters);
                }

                string reversedStr = String.Join(" ", words);
                Console.WriteLine(reversedStr);
        }
    }
}
