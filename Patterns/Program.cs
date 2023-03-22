namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Option:-> 1.DuplicateElement 2.UniqueElement 3.FrequencyElement 4.MaxMinElement 5.Patterns");
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
            }
        }
    }
}