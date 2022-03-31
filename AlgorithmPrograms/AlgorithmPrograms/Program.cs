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
            Console.WriteLine("4 For Bubble Sort");
            Console.WriteLine("5 For Merge Sort");
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
                    string StringData = "Mango Apple Banana Watermelon Orange Grapes";
                    string[] SplitString = StringData.Split(" ");
                    Console.Write("Sorted string : ");
                    insertionSort.InsertSort(SplitString);
                    foreach (var item in SplitString)
                    {
                        Console.Write(item + " ");
                    }
                    break;
                case 4:
                    BubbleSort bubbleSort = new BubbleSort();
                    StringData = "Mango Apple Banana Watermelon Orange Grapes";
                    SplitString = StringData.Split(" ");
                    bubbleSort.BubbleSorting(SplitString);
                    bubbleSort.Display(SplitString);
                    break;
                case 5:
                    MergeSort mergeSort = new MergeSort();
                    StringData = "Mango Apple Banana Watermelon Orange Grapes";
                    SplitString = StringData.Split(" ");
                    string[] SortedString = mergeSort.Sort(SplitString, 0, SplitString.Length - 1);
                    mergeSort.Display(SortedString);
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
