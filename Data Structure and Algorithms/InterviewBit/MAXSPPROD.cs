using System.Collections.Generic;

namespace InterviewBit
{
    class MAXSPPROD
    {
        public int maxSpecialProduct(List<int> A)
        {
            
            int MaxProd = 0;

            for (int i = 0; i < A.Count; i++)
            {
                int LSV = 0;
                int RSV = 0;

                int LMaxProd = LSV * RSV;

                if ((A.Count - i - 1) == 0 || (A.Count - i) == A.Count)
                {
                    LSV = 0;
                    RSV = 0;
                }
                else
                {
                    int x = i - 1;
                    int y = i + 1;

                    while (x >= 0)
                    {
                        if (A[i] < A[x])
                        {
                            LSV = x;
                            break;
                        }
                        x--;
                    }

                    while (y < A.Count)
                    {
                        if (A[i] < A[y])
                        {
                            RSV = y;
                            break;
                        }
                        y++;
                    }

                    LMaxProd = LSV * RSV;

                    if (LMaxProd >= MaxProd)
                    {
                        MaxProd = LMaxProd;
                    }
                }
            }
            return MaxProd;
        }
    }
}
