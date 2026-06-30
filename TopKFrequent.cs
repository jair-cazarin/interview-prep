public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var frequencies = new Dictionary<int, int>();
        var heap = new PriorityQueue<int, int>();
        foreach(var n in nums)
        {
            if (frequencies.ContainsKey(n))
            {
                frequencies[n]++;
            }
            else
            {
                frequencies[n] = 1;
            }
        }

        foreach(var kvp in frequencies)
        {
            int num = kvp.Key;
            int frequency = kvp.Value;

            if (heap.Count < k)
            {
                heap.Enqueue(num, frequency);
            }
            else
            {
                heap.TryPeek(out var element, out var priority);
                if (priority < frequency)
                {
                    heap.Dequeue();
                    heap.Enqueue(num, frequency);
                } 
            }
        }

        var result = new int[k];
        for(var i = 0; i < k; i++)
        {
            result[i] = heap.Dequeue();
        }
        return result;
    }
}
