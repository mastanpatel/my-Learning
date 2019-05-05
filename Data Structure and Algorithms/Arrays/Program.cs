using System;

namespace Arrays
{
    class Program
    {

        static void Main(string[] args)
        {
            #region oldcode

            //int[] arr = new int[6];
            //arr[0] = 3; arr[1] = 2; arr[2] = 4; arr[3] = 11; arr[4] = 22;

            //ArrayOperations a = new ArrayOperations();

            ////insertion at the end cost O(1)
            //arr = a.insertAtend(3, arr, 6);

            //foreach (var item in arr)
            //{
            //    Console.Write("{0} ", item);
            //}

            ////insertion inbetween or starting cost O(1)
            //arr = a.insertInbetween(12, arr, 4);
            //Console.WriteLine("\ninsertion inbetween array:");
            //foreach (var item in arr)
            //{
            //    Console.Write("{0} ", item);
            //}

            //int n = a.deleteInbetween(12, arr, 4);
            //Console.WriteLine("\ndeletion inbetween array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("{0} ", arr[i]);
            //}

            //int pos = a.searchElement(arr, 22);
            //if (pos > 0)
            //{
            //    Console.WriteLine("\nThe element:{0} Found at position:{1}", arr[pos], pos + 1);
            //}
            //else
            //{
            //    Console.WriteLine("\nNo element Found in the aarray.");
            //}
            //Console.ReadKey();




            //-------------\
            //subArraySum sb = new subArraySum();
            //int[] numbers = new int[] { 1, 2, 3, 4, 15, 7, 19, 12, 10, 8 };

            //IEnumerable e = sb.getIndex(10, 18, numbers);

            //foreach (var item in e)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();m
            ////sb.ArraySum(numbers, 10, 18);
            ////Console.ReadKey();

            //string inputValues = Console.ReadLine();
            //string[] inputValue = inputValues.Split(' ');
            //int arraySize = int.Parse(inputValue[0]);
            //int arraySum = int.Parse(inputValue[1]);
            //int[] arr = new int[arraySize];
            //string inputArray = Console.ReadLine();
            //string[] inputArr = inputArray.Split(' ');

            //for (int j = 0; j < inputArr.Length; j++)
            //{
            //    arr[j] = int.Parse(inputArr[j]);
            //}

            //sb.ArraySum(arr, arraySize, arraySum);

            #endregion

            // missingNumber.MainMethod();
            //sortZeroOneTwoArray.Mainmethod();
            //arrayEquilibrium.MainMethod();
            minDiference.MainMethod();
            
            Console.ReadKey();
        }

    }
}
