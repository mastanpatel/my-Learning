using System;
using System.Collections.Generic;

namespace InterviewBit
{
    class DuplicateArray
    {
        public int repeatedNumber(List<int> A)
        {


            for (int i = 0; i < A.Count; i++)
            {
                if (A[Math.Abs(A[i])] >= 0)
                    A[Math.Abs(A[i])] =
                        -A[Math.Abs(A[i])];
                else
                    return Math.Abs(A[i]);

            }
            return -1;
        }
            //for (int i = 0; i < A.Count; i++)
            //{
            //    for (int j = i + 1; j < A.Count; j++)
            //    {
            //        if (A[i]==A[j])
            //        {
            //            calcount++;
            //            Console.WriteLine("calcumations: " + calcount);
            //            return A[i];
            //        }

            //        calcount++;
            //    }
            //}

           
    }
}
