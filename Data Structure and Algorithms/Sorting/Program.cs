using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr =  { 34,2,4,1,4,1,5,3 };
            //bubbleSort.BubbleSorting(arr);
            //insertionSort.insertionSorting(arr);
            SelectionSort.selectionSorting(arr);
            //Day d = (Day)4;
            Console.ReadKey();
        }
    }
}
