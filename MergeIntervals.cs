public class Solution {
    public int[][] Merge(int[][] intervals) {
        var result = new List<int[]>();
        if (intervals.Length == 0)
        {
            return result.ToArray();
        }
        Array.Sort(intervals, (a, b) => a[0] - b[0]);
        result.Add(intervals[0]);

        for(var i = 1; i < intervals.Length; i++)
        {
            if (Overlap(intervals[i], result[result.Count - 1]))
            {
                var mergedInterval = Merge(intervals[i], result[result.Count - 1]);
                result[result.Count - 1] = mergedInterval;
            }
            else
            {
                result.Add(intervals[i]);
            }
        }

        return result.ToArray();
    }

    private static bool Overlap(int[] a, int[] b)
    {
        return b[0] <= a[1];
    }

    private static int[] Merge(int[] a, int[] b)
    {
        return new int[]
        {
            Math.Min(a[0], b[0]),
            Math.Max(a[1], b[1])
        };
    }
}
