using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] A)
    {
        ReadInput(A, out int[] start, out int[] end);
        int intersections = 0, started = 0;
        for (int startIndex = 0, endIndex = 0;  startIndex < A.Length; )
        {
            if (start[startIndex] <= end[endIndex])
            {
                startIndex++;
                started++;
                if (started > 1)
                {
                    int addIntersec = started - 1;
                    intersections += addIntersec;
                }
            }
            else 
            {
                started--;
                endIndex++;
            }
        }
        if(intersections > 10_000_000)
        {
            return -1;
        }
        return intersections;
    }

    private static void ReadInput(int[] A, out int[] starts, out int[] ends)
    {
        starts = new int[A.Length];
        ends = new int[A.Length];
        for (int centrPnt = 0; centrPnt < A.Length; centrPnt++)
        {
            int radius = A[centrPnt];
            int minPnt = centrPnt - radius > 0 ? centrPnt - radius : 0;
            int maxPnt = centrPnt + radius;
            starts[centrPnt] = minPnt;
            ends[centrPnt] = maxPnt;
        }
        Array.Sort(starts);
        Array.Sort(ends);
    }

    static void Main(string[] args)
    {
        Solution s = new Solution();
        int[] arr = new int[] {1 ,1 ,1 ,1 };
        int pairs = s.solution(arr);
        //s.PrintPtns();
        Console.WriteLine("pairs count: " + pairs);
    }
}

