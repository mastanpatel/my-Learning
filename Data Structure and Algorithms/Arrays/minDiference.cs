using System;

namespace Arrays
{
    class minDiference
    {
        static void findMinimumProd(long[] arr, int size)
        {
            long leftProd = 0;
            long rightProd = 0;
            long lMin = 0;
            long gMin = lMin;
            int minX = 0;

            if (size == 1)
            {
                Console.WriteLine(0);
                return;
            }

            leftProd = arr[0];

            for (int i = 1; i < size; i++)
            {
                if (arr[i] < 1) return;
                rightProd += arr[i];
            }

            gMin = Math.Abs(rightProd - leftProd);
            //if(rightProd > leftProd)  gMin = rightProd - leftProd;
            //else gMin = leftProd - rightProd;

            if (gMin == 0)
            {
                Console.WriteLine(1);
                return;
            }

            for (int j = 1; j < size; j++)
            {
                if (arr[j] != 1)
                {
                    leftProd += arr[j];
                    rightProd = rightProd - arr[j];

                    lMin = Math.Abs(rightProd - leftProd);
                    //if(rightProd > leftProd) lMin = rightProd - leftProd;
                    //else lMin = leftProd - rightProd;
                }

                if (gMin >= lMin)
                {
                    gMin = lMin;
                    minX = j;
                }

                if (gMin == 0)
                {
                    Console.WriteLine(minX + 1);
                    return;
                }

            }

            Console.WriteLine(minX + 1);

            // Console.WriteLine("minimum");
        }
        public static void MainMethod()
        {
            var arraySize = int.Parse(Console.ReadLine().Trim());
            var arrayString = Console.ReadLine().Trim();
            var arrayElements = arrayString.Split(' ');
            long[] arr = new long[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                arr[i] = long.Parse(arrayElements[i].ToString());
            }

            findMinimumProd(arr, arraySize);

            //Console.WriteLine("Mastan");
        }
    }
}
