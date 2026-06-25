public class Solution {
    private static Dictionary<char, char> map = new Dictionary<char, char>() {
        { ')', '('},
        { '}', '{'},
        { ']', '['},
    };

    public bool IsOpen(char c)
    {
        return (c == '(' || c == '{' || c == '[');
    }
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        foreach(var c in s)
        {
            if (IsOpen(c))
            {
                stack.Push(c);
            } 
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                var open = stack.Pop();
                if (map[c] != open)
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}
