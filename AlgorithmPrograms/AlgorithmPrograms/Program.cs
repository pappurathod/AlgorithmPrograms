using System;
namespace AlgorithmPrograms
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Your Choice");
            Console.WriteLine("1 For String Permutations");
            Console.WriteLine("2 For Binary Search");
            Console.WriteLine("3 For Insertion Sort");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    StringPermutation stringPermutation = new StringPermutation();
                    stringPermutation.UserInput();
                    break;
                case 2:
                    BinarySearch bSearch = new BinarySearch();
                    Console.WriteLine("Enter the element for search ");
                    string word = Console.ReadLine();
                    int result = bSearch.binarySearch(word);
                    if (result == 1)
                        Console.WriteLine("Element not present");
                    else
                        Console.WriteLine("Element found at index " + result);
                    break;
                case 3:
                    InsertionSort insertionSort = new InsertionSort();
                    string GivenString = "Mango Apple Banana Watermelon Orange Grapes";
                    string[] SplitString = GivenString.Split(" ");
                    Console.Write("Sorted string : ");
                    insertionSort.InsertSort(SplitString);
                    foreach (var item in SplitString)
                    {
                        Console.Write(item + " ");
                    }
                    break;

                case 10:
                    Console.Write("Thank you");
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
        }
    }
}
