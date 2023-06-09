﻿namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Option:-> 1.DuplicateElement 2.UniqueElement 3.FrequencyElement 4.MaxMinElement " +
                                              "5.Patterns 6.ReverseWord 7.SumOFAllDigit 8.SumOfRowOfMatrix");
            int option =Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                    case 1:
                    DuplicateArrayElements.Duplicate();
                    break;
                    case 2:
                    UniqueElement.Unique();
                    break;
                    case 3:
                    FrequencyOfElement.FrequencyArray();
                    break;
                    case 4:
                    MaxMinElement.MaxMinElementArray();
                    break;
                    case 5:
                    Console.WriteLine("1st Pattern:-");
                    Pattern.ReactangleReverse();
                    Console.WriteLine("2nd Pattern:-");
                    Pattern.PrintReactangle();
                    break;
                    case 6:
                    ReverseWord.ReverseEachWord();
                    break; 
                    case 7:
                    SumOfAllDigit.sum();
                    break;
                    case 8:
                    SumOfMatrix.SumOfRowOfMatrix();
                    break;
            }
        }
    }
}