public class MedianFinder {

    private PriorityQueue<int, int> left;
    private PriorityQueue<int, int> right;

    public MedianFinder() {
        this.left = new PriorityQueue<int, int>();
        this.right = new PriorityQueue<int, int>();
    }

    public void AddNum(int num)
    {
        left.Enqueue(num, -num);
        if (right.Count > 0 && left.Peek() > right.Peek())
        {
            var elem = left.Dequeue();
            right.Enqueue(elem, elem);
        }

        // balance it out
        if (left.Count > right.Count + 1)
        {
            var elem = left.Dequeue();
            right.Enqueue(elem, elem);
        } else if (right.Count > left.Count)
        {
            var elem = right.Dequeue();
            left.Enqueue(elem, -elem);
        }
    }

    public double FindMedian() {
        if (left.Count == 0 && right.Count == 0)
        {
            return 0;
        } 

        if ((left.Count + right.Count) % 2 == 0)
        {
            return (left.Peek() + right.Peek()) / 2.0;
        }

        return left.Count > right.Count ? left.Peek() : right.Peek();
    }
}
