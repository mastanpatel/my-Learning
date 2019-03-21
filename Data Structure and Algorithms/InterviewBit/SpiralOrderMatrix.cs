using System.Collections.Generic;
namespace InterviewBit
{
    class SpiralOrderMatrix
    {

        public List<List<int>> generateMatrix(int n)
        {
            var a = new int[n, n];
            var t = 0;
            var r = n - 1;
            var b = n - 1;
            var l = 0;
            var dir = 0;
            var i = 1;
            while (i <= n * n)
            {
                if (dir == 0)
                {
                    for (int j = l; j <= r; j++)
                    {
                        a[t, j] = i++;
                    }
                    t++;
                    dir = 1;
                }
                else if (dir == 1)
                {
                    for (int j = t; j <= b; j++)
                        a[j, r] = i++;
                    r--;
                    dir = 2;
                }
                else if (dir == 2)
                {
                    for (int j = r; j >= l; j--)
                        a[b, j] = i++;
                    b--;
                    dir = 3;
                }
                else if (dir == 3)
                {
                    for (int j = b; j >= t; j--)
                        a[j, l] = i++;
                    l++;
                    dir = 0;
                }
            }
            var res = new List<List<int>>();
            for (int x = 0; x < n; x++)
            {
                res.Add(new List<int>());
                for (int y = 0; y < n; y++)
                {
                    res[x].Add(a[x, y]);
                }
            }
            return res;
        }
    }




    //public List<List<int>> generateMatrix(int A)
    //{
    //    int[,] matrix = getMatrix(A);


    //    int x = 0;

    //    while (x < A)
    //    {
    //        List<int> miniList = new List<int>();

    //        for (int i = 0; i < A - 1; i++)
    //        {
    //            miniList.Add(matrix[x, i]);
    //        }

    //        finalList.Add(miniList);
    //    }

    //    return finalList;
    //}


    //public int[,] getMatrix(int A)
    //{
    //    int rowEnd = A;
    //    int colEnd = A;
    //    int rowStart = 0;
    //    int colStart = 0;
    //    int Element = 0;

    //    int[,] matrix = new int[A, A];

    //    while (rowStart < rowEnd && colStart < colEnd)
    //    {

    //        //print the first row from remaining rows
    //        for (int i = colStart; i < colEnd; i++)
    //        {
    //            Element += 1;
    //            matrix[rowStart, i] = Element;
    //        }
    //        rowStart++;


    //        //print the last column from remaining Columns

    //        for (int i = rowStart; i < rowEnd; i++)
    //        {
    //            Element += 1;
    //            matrix[i, colEnd - 1] = Element;
    //        }
    //        colEnd--;


    //        //print the last row from remaining rows

    //        if (rowStart < rowEnd)
    //        {
    //            for (int i = colEnd - 1; i >= colStart; --i)
    //            {
    //                Element += 1;
    //                matrix[rowEnd - 1, i] = Element;
    //            }
    //            rowEnd--;

    //        }

    //        //print the first column from remaining columns
    //        if (colStart < colEnd)
    //        {
    //            for (int i = rowEnd - 1; i >= rowStart; --i)
    //            {
    //                Element += 1;
    //                matrix[i, colStart] = Element;
    //            }
    //            colStart++;
    //        }

    //    }

    //    return matrix;

    //}
}
