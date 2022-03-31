using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class BinarySearch
    {
        public int binarySearch(String Search_ele)
        {
            String[] arr = { "Apple", "Banana", "Orange", "Grapes" };
            int left_ind = 0, right_ind = arr.Length - 1;
            while (left_ind <= right_ind)
            {
                int temp = left_ind + (right_ind - left_ind)/2;
                int res = Search_ele.CompareTo(arr[temp]);

                if (res == 0)
                    return temp;
                if (res > 0)
                    left_ind = temp + 1;
                else
                    right_ind = temp - 1;
            }
            return 1;
        }
    }
}