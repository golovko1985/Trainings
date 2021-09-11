using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] A)
    {
        int[] start = new int[A.Length];
        int[] end = new int[A.Length];
        for(int centrPnt = 0; centrPnt < A.Length; centrPnt++)
        {
            int radius = A[centrPnt];
            int minPnt = centrPnt - radius > 0 ? centrPnt - radius : 0;
            int maxPnt = centrPnt + radius;
            start[centrPnt] = minPnt;
            end[centrPnt] = maxPnt;
        }
        Array.Sort(start);
        Array.Sort(end);

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
        return intersections;
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

