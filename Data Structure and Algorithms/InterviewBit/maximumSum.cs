using System.Collections.Generic;

namespace InterviewBit
{
    class maximumSum
    {
        // -2, 1, -3, 4, -1, 2, 1, -5, 4


        public int maxSubArray(List<int> A)
        {
            int Fsum = A[0];
           // int Csum = 0;
            int Lsum = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (Lsum >= A[i] || Lsum > 0)
                {
                    Lsum += A[i];
                   
                }
                else
                {
                    Lsum = A[i];
                }
                
                if (Fsum < Lsum)
                {
                    Fsum = Lsum;
                    //Lsum = 0;
                }

                if (Lsum < 0 && Lsum < Fsum)
                {
                    Lsum = 0;
                }

                
            }
            return Fsum;
        }
    }
}
