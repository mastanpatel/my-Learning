using System;

namespace Arrays
{
    class missingNumber
    {
        static void findMissingNumber()
        {

            int size = int.Parse(Console.ReadLine());
            int sum = size * (size + 1) / 2;
            int[] arr = new int[size];
            string inputArray = Console.ReadLine();
            string[] inputArr = inputArray.Split(' ');

            for (int j = 0; j < size - 1; j++)
            {
                arr[j] = int.Parse(inputArr[j]);
                sum -= arr[j];
            }
            Console.WriteLine(sum);
        }

        public static void MainMethod()
        {
            int testCase = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCase; i++)
            {
                findMissingNumber();
            }
        }
    }
}
