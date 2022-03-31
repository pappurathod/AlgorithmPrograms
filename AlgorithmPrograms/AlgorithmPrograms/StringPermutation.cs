using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class StringPermutation
    {
        public void UserInput()
        {
            Console.WriteLine("String permutations");
            Console.Write("Enter String: ");
            string Sentence = Console.ReadLine();
            Recursion(Sentence, 0);            
        }

        public static void Recursion(string Sentence, int start)
        {
            int Length = Sentence.Length;

            for (int i = start; i < Length; i++)
            {
                Sentence = (Swap(Sentence, start, i));
                Console.WriteLine(Sentence);
                Recursion(Sentence, start + 1);
                Sentence = Swap(Sentence, start, i);
            }
        }
        public static string Swap(string Sentence, int start, int end)
        {
            char temp;
            char[] charArray = Sentence.ToCharArray();
            temp = charArray[start];
            charArray[start] = charArray[end];
            charArray[end] = temp;
            string s = new string(charArray);
            return s;
        }        
    }
}
