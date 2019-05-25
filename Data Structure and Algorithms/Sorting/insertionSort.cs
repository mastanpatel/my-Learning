using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class insertionSort
    {
        public static void insertionSorting(int [] arr)
        {
            // 3 4 2 5 1
            // 1 2 3 4 5

            for (int i = 0; i < arr.Length; i++)
            {
                int j = i-1;
                int keyElement = arr[i];
                while (j >= 0 && keyElement < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = keyElement;
            }

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
