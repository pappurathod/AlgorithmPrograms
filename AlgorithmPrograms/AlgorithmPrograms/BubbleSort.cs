using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class BubbleSort
    {
        public void BubbleSorting<T>(T[] StringData)
        {
            for (int itr = 0; itr <= StringData.Length - 1; itr++)
            {
                T temp;
                for (int j = 0; j < StringData.Length - 1 - itr; j++)
                {
                    if (Comparer<T>.Default.Compare(StringData[j], StringData[j + 1]) > 0)
                    {
                        temp = StringData[j + 1];
                        StringData[j + 1] = StringData[j];
                        StringData[j] = temp;
                    }
                }

            }
            Console.Write("\n sorted string: ");
            Display(StringData);
        }

        public void Display<T>(T[] GivenString)
        {
            foreach (T Strings in GivenString)
            {
                Console.Write(Strings + " ");
            }
        }
    }

}