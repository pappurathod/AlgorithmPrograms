using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class MergeSort
    {
        public void Merge(string[] GivenString, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;
            string[] left = new string[n1];
            string[] right = new string[n2];
            int i, j;
            for (i = 0; i < n1; ++i)
            {
                left[i] = GivenString[l + i];
            }
            for (j = 0; j < n2; ++j)
            {
                right[j] = GivenString[m + 1 + j];
            }

            i = 0;
            j = 0;
            int k = l;
            while (i < n1 && j < n2)
            {
                if (left[i].CompareTo(right[j]) <= 0)
                {
                    GivenString[k] = left[i];
                    i++;
                }
                else
                {
                    GivenString[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                GivenString[k] = left[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                GivenString[k] = right[j];
                j++;
                k++;
            }
        }
        public string[] Sort(string[] GivenString, int l, int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2;
                Sort(GivenString, l, m);
                Sort(GivenString, m + 1, r);
                Merge(GivenString, l, m, r);
            }
            return GivenString;
        }

        public void Display(string[] GivenString)
        {
            foreach (string Strings in GivenString)
            {
                Console.Write(Strings + " ");
            }
        }
    }

}