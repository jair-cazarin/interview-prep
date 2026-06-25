public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
        this.val = val; this.left = left; this.right = right;
    }
}

public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var result = new List<List<int>>();
        if (root == null) {
            return result;
        }

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count > 0) {
            var nodesToProcess = queue.Count;
            var levelList = new List<int>();
            result.Add(levelList);
            for(var i = 0; i < nodesToProcess; i++) {
                var currentNode = queue.Dequeue();
                levelList.Add(currentNode.val);

                if (currentNode.left != null) {
                    queue.Enqueue(currentNode.left);
                }
                if (currentNode.right != null) {
                    queue.Enqueue(currentNode.right);
                }
            }
        }
        return result;
    }
}
