using System;

namespace Sorting
{
    class SelectionSort
    {
        public static void selectionSorting(int [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minElement = arr[i];
                int lastIndex = arr.Length - 1;
                int minIndex = i;
                while (lastIndex > i)
                {
                    if (minElement > arr[lastIndex])
                    {
                        minElement = arr[lastIndex];
                        minIndex = lastIndex;
                    }

                    lastIndex--;
                }

                int temp = arr[i];
                arr[i] = minElement;
                arr[minIndex] = temp;
            }

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
