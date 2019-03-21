using System;

namespace InterviewBit
{
    class MinStep
    {
        internal int GetminimumSteps(int[] x, int[] y)
        {
            int steps = 0;

            for (int i = 0; i < x.Length-1; i++)
            {
                steps += GetSteps(x[i], y[i], x[i + 1], y[i + 1]);
            }
            return steps;
        }

        private int GetSteps(int x1, int y1, int x2, int y2)
        {
            int maxOfx = Math.Abs(x2-x1);
            int maxOfy = Math.Abs(y2-y1);

            return Math.Max(maxOfx,maxOfy);
        }
    }
}
