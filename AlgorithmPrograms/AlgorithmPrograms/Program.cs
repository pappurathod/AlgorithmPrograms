using System;
namespace AlgorithmPrograms
{
    class Program
    {
        public static void Main(String[] args)
        {
            StringPermutation stringPermutation = new StringPermutation();
            stringPermutation.UserInput();

            BinarySearch bSearch = new BinarySearch();
            Console.WriteLine("Enter the element for search ");
            string word = Console.ReadLine();
            int result = bSearch.binarySearch(word);
            if (result == 1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index " + result);
        }
    }
}
