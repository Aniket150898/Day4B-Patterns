namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Option:-> 1.DuplicateElement 2.UniqueElement 3.FrequencyElement");
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
            }
        }
    }
}