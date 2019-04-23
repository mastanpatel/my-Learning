using System;
using System.Collections;
namespace Arrays
{
    class subArraySum
    {

        public IEnumerable getIndex(int arraySize, int Sum, int[] arr)
        {
            int[] Indexes = new int[2];
            int iSum = 0;
            //TODO : write logic 
            for (int i = 0; i < arraySize; i++)
            {
                for (int j = i; j < arraySize; j++)
                {
                    if (iSum > Sum)
                    {
                        iSum = 0;
                        break;
                    }
                    else if(iSum < Sum)
                    {
                        iSum += arr[j];
                    }
                    else if(iSum == Sum)
                    {
                        Indexes[0] = i+1;
                        Indexes[1] = j;
                        return Indexes;
                    }
                }
            }
            return Indexes;
        }


         public int ArraySum(int[] arr, int n, int sum)  
        { 
            int curr_sum = arr[0],  
                     start = 0, i; 
  
            // Pick a starting point 
            for (i = 1; i <= n; i++)  
            { 
                // If curr_sum exceeds   
                // the sum, then remove 
                // the starting elements 
                while (curr_sum > sum &&  
                       start < i - 1) 
                { 
                    curr_sum = curr_sum -  
                               arr[start]; 
                    start++; 
                } 
              
                // If curr_sum becomes equal to 
                // sum, then return true 
                if (curr_sum == sum)  
                { 
                    int p = i-1; 
                    Console.WriteLine("Sum found between " + 
                                         "indexes " + start+  
                                               " and " + p); 
                    return 1; 
                } 
              
                // Add this element to curr_sum 
                if (i < n) 
                curr_sum = curr_sum + arr[i]; 
              
            } 
            Console.WriteLine("No subarray found"); 
            return 0; 
        } 
  
    }
}
