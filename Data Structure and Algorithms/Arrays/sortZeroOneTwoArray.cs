using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class sortZeroOneTwoArray
    {
        static void sortArray(int size, int countZero, int countOne, int countTwo)
        {
            for (int i = 0; i < size; i++)
            {
                if (i < countZero)
                    Console.Write(0 + " ");

                else if (i < (countZero + countOne))
                    Console.Write(1 + " ");

                else Console.Write(2 + " ");
            }
        }
        static public void Mainmethod()
        {
            int countZero = 0, countOne = 0, countTwo = 0;

            int testCase = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCase; i++)
            {

                int arraySize = int.Parse(Console.ReadLine());

                int[] arr = new int[arraySize];
                string inputArray = Console.ReadLine();
                string[] inputArr = inputArray.Split(' ');

                for (int j = 0; j < arraySize; j++)
                {
                    arr[j] = int.Parse(inputArr[j]);

                    if (arr[j] == 0) countZero++;
                    else if (arr[j] == 1) countOne++;
                    else countTwo++;
                }

                sortArray(arraySize, countZero, countOne, countTwo);
                Console.WriteLine();
            }
        }
    }
}
