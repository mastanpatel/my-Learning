using System;

namespace Sorting
{
    class bubbleSort
    {
        static void Swap(int [] arr,int a,int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
        public static void BubbleSorting(int [] arr)
        {
            //2 4 1 5 3
            //1 2 3 4 5

            bool isSwap = true;
            int lastIndex = arr.Length - 1;

            while (isSwap)
            {
                isSwap = false;
                for (int i = 0; i < lastIndex; i++)
                {
                    if (arr[i] > arr[i+1])
                    {
                        Swap(arr, i, i+1);
                        isSwap = true;
                    }
                }

                lastIndex--;
            }

            foreach (var item in arr)
            {
                Console.Write(item +" ");
            }

        }
    }
}
