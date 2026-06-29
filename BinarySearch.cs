public class Solution {
    public int Search(int[] nums, int target) {
        var start = 0;
        var end = nums.Length - 1;

        while(start <= end)
        {
            var middle = start + (end - start) / 2;
            if (nums[middle] == target)
            {
                return middle;
            } 
            else if (nums[middle] > target)
            {
                end = middle - 1;    
            } 
            else
            {
                start = middle + 1;    
            }
        }

        return -1;
    }
}
