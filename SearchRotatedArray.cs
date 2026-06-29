public class Solution {
    public int Search(int[] nums, int target) {
        var start = 0;
        var end = nums.Length - 1;

        while(start <= end)
        {
            var mid = start + (end - start)/2;

            if (nums[mid] == target)
            {
                return mid;
            }
            // left sorted
            else if (nums[start] <= nums[mid]) 
            {
                if (nums[start] <= target && target < nums[mid])
                {
                    end = mid - 1;                
                } 
                else
                {
                    start = mid + 1;
                }
            } 
            else
            {
                if (nums[mid] < target && target <= nums[end])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
        }

        return -1;
    }
}
