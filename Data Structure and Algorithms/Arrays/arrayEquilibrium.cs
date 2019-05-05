using System;

namespace Arrays
{
    class arrayEquilibrium
    {
        static int getEquilibrium(int[] arr, int size)
        {
            int rSum = 0;
            int lSum = 0;
            int position = -1;
            if (size == 1)
                return 1;
            else
            {
                lSum = arr[0];

                for (int i = 1; i < size; i++)
                {
                    rSum += arr[i];
                }

                for (int j = 1; j < size; j++)
                {
                    rSum -= arr[j];
                    if (lSum == rSum)
                    {
                        position = (j + 1);
                        break;
                    }

                    else if (lSum < rSum)
                    {
                        lSum += arr[j];
                    }

                }
            }

            return position;
        }


        static public void MainMethod()
        {
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
                }

                Console.Write(getEquilibrium(arr, arraySize));
                Console.WriteLine();
            }
        }
    }
}
