public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var result = new int[temperatures.Length];
        var s = new Stack<int>();
        for(var i = 0; i < temperatures.Length; i++)
        {
            while(s.Count > 0 && temperatures[s.Peek()] < temperatures[i])
            {
                var currentIndex = s.Pop();
                result[currentIndex] = i - currentIndex;
            }

            s.Push(i);
        }

        return result;
    }
}
