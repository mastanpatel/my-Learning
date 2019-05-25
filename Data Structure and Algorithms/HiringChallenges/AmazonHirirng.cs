using System;
using System.Collections.Generic;

namespace HiringChallenges
{
    class AmazonHirirng
    {
        static SortedDictionary<int, int> dic = new SortedDictionary<int, int>();
        static int sum = 0;

        private static int getBorderSum(int queryValue, int size)
        {
            
            if (dic.Count == 0)
            {
                dic.Add(queryValue, 0);
                sum = 1 + size;
            }
            else
            {
                if (dic.ContainsKey(queryValue))
                {
                    return sum;
                }
                else
                {
                    dic.Add(queryValue, 0);

                    sum = getLatestSum(dic, queryValue);
                }
            }

            return sum;
        }

        private static int getLatestSum(SortedDictionary<int, int> dic, int queryValue)
        {
            SortedDictionary<int, int>.KeyCollection.Enumerator key = dic.Keys.GetEnumerator();
            int preValue = 0;
            key.MoveNext();

            for (int i = 0; i < dic.Keys.Count; i++)
            {
                if (key.Current == queryValue)
                {
                    if (key.MoveNext())
                    {
                        //if(key.Current - queryValue == 1) sum += queryValue + key.Current - 1;
                        //else 
                        sum += queryValue + key.Current - 2;

                        return sum;
                    }
                    else if (!key.MoveNext())
                    {
                        sum += queryValue + preValue;
                        return sum;

                    }
                }
                else
                {
                    preValue = key.Current;
                    key.MoveNext();
                }
   
            }
            return sum;
        }
        public static void MainMethod()
        {
            string[] input = Console.ReadLine().Split(' ');

            int[] queyValues = {2,7,5,9,6,1,8,10,3,4 };

            int Size = int.Parse(input[0]);
            int Queries = int.Parse(input[1]);

            for (int i = 0; i < Queries; i++)
            {
                int queryValue = queyValues[i];

                Console.WriteLine(getBorderSum(queryValue, Size));
            }
        }

    }
}
