using System;

namespace Arrays.Properties
{
    class Kadane_s_Algorithm
    {
        static int maxSumSubArray(int[] arr, int size)
        {
            //1,2,3
            int lSum = arr[0];
            int gSum = lSum;

            for (int i = 1; i < size; i++)
            {
                //if (lSum < 0 && arr[i] >= 0)
                //{
                //    lSum = arr[i];
                //}
                //else
                //    lSum = lSum + arr[i];
                //replace above code with
                lSum = Math.Max(arr[i], arr[i] + lSum);

                //if (lSum >= gSum)
                //{
                //    gSum = lSum;
                //}
                //replace above code with 
                gSum = Math.Max(lSum, gSum);
            }
            Console.WriteLine(gSum);
            return gSum;
        }
    }
}
