public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();
        for(var i = 0; i < strs.Length; i++) 
        {
            var sorted = string.Concat(strs[i].OrderBy(c => c));
            if (!map.ContainsKey(sorted)) 
            {
                map[sorted] = new List<string>();
            }

            map[sorted].Add(strs[i]);   
        }

        return new List<IList<string>>(map.Values);
    }
}
