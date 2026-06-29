public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }

        var start = 0;
        var end = 1;
        var maxLength = 1;

        var map = new HashSet<char>();
        map.Add(s[0]);
        while(end < s.Length)
        {
            if (!map.Contains(s[end]))
            {
                map.Add(s[end]);
                end++;
            } 
            else
            {
                while(map.Contains(s[end]))
                {
                    map.Remove(s[start++]);
                }    
                map.Add(s[end]);
                end++;
            }
            maxLength = Math.Max(maxLength, end - start);
        }

        return maxLength;
    }
}
