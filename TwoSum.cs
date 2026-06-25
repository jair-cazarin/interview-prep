public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var hash = new Dictionary<int, int>();
        for(var i = 0; i < nums.Length; i++) {
            var complement = target - nums[i];
            if (hash.ContainsKey(complement)) {
                return new int [] { i, hash[complement] };               
            }
            hash[nums[i]] = i;
        }
        return new int[] { -1, -1 };
    }
}

// 1, 4, -2, 4, 5
// target = 3

// 1 - 3 = -2 
// 3 - 1 = 2