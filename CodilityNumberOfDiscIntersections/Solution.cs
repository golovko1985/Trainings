using System;
using System.Collections.Generic;

public class Solution
{
    private static Dictionary<int, int> discCounts;
    private static Dictionary<int, int> accum;

    public Solution()
    {
        discCounts = new();
        accum = new();
    }

    public int solution(int[] A)
    {
        int pairsCount = 0;
        for (int discNum = 1; discNum <= A.Length; discNum++)
        {
            int centrPnt = discNum - 1;
            int radius = A[centrPnt];
            int minPnt = centrPnt - radius > 0 ? centrPnt - radius : 0;
            int maxPnt = centrPnt + radius;

            pairsCount += getPairsCount(minPnt, maxPnt, discNum);
            if (pairsCount > 10_000_000) return -1;
        }
        return pairsCount;
    }

    public static int getPairsCount(int minPnt, int maxPnt, int discNum)
    {
        List<int> pairs = new List<int>();
        //List<int> counts = new List<int>();
        for (int x = minPnt; x <= maxPnt; x++)
        {
            if (accum.ContainsKey(x))
            {
                accum[x] += discNum;
                discCounts[x]++;
            }
            else
            {
                accum.Add(x, discNum);
                discCounts.Add(x, 1);
            }

            if (discCounts[x] > 1 && pairs.IndexOf(accum[x]) == -1)
            {
                //counts.Add(discCounts[x]);
                for (int i = 1; i < discCounts[x]; i++) {
                    pairs.Add(accum[x]);
                }

            }
            else if (discCounts[x] > 1)
            {
                int indexWhenAccumRepeated = pairs.IndexOf(accum[x]);
                if (discCounts[indexWhenAccumRepeated] != discCounts[x])
                {
                    //counts.Add(discCounts[x]);
                    pairs.Add(accum[x]);
                }

            }
            //int curPairs = 0;
            //if (pairs.Count > x)
            //{
            //    curPairs = pairs[x];
            //}
            //int curCounts = 0;
            //if (counts.Count > x)
            //{
            //    curCounts = counts[x];
            //}
            //Console.Write(" discCounts[" + x + "]: " + discCounts[x]);
            //Console.Write(" accum[" + x + "]: " + accum[x]);
            //Console.Write(" pairs[" + x + "]: " + curPairs);
            //Console.Write(" counts[" + x + "]: " + curCounts);
            //Console.Write("\n");
        }
        return pairs.Count;

    }

    public void PrintPtns()
    {
        for (int i = 0; i < discCounts.Count; i++)
        {

            Console.Write(" discCounts[" + i + "]: " + discCounts[i]);
            Console.Write(" accum[" + i + "]: " + accum[i]);

            Console.Write("\n");
        }
    }

    static void Main(string[] args)
    {
        Solution s = new Solution();
        int[] arr = new int[] { 1, 0, 1};
        int pairs = s.solution(arr);
        //s.PrintPtns();
        Console.WriteLine("pairs count: " + pairs);

    }
}

