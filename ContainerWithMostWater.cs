public class Solution {
    public int MaxArea(int[] height) {
        var maxArea = 0;
        var start = 0;
        var end = height.Length - 1;

        while(start < end)
        {
            var area = Math.Min(height[start], height[end]) * (end - start);
            maxArea = Math.Max(maxArea, area);
            if (height[start] > height[end])
            {
                end--;
            } else
            {
                start++;
            }
        }

        return maxArea;
    }
}
