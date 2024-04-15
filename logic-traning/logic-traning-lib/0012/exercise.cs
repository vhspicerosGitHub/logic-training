namespace logic_traning_lib._0012
    ;
internal class exercise
{
    public bool IsCousins(TreeNode root, int x, int y)
    {
        Dictionary<int, (int p, int d)> dict = new Dictionary<int, (int, int)>();
        DFS(root, x, y ,dict, 0, 0);
        foreach (var d in dict.Keys)
        {
            Console.WriteLine(d);
            Console.WriteLine(dict[d]);
        }

        return ((dict[x].d == dict[y].d) && (dict[x].p != dict[y].p));
    }

    private void DFS(TreeNode node, int x, int y, Dictionary<int, (int p, int d)> dict, int parent, int curDepth)
    {
        if (node != null)
        {
            if (!dict.ContainsKey(x) && !dict.ContainsKey(x))
            {
                dict.Add(node.val, (parent, curDepth));
                DFS(node.left, x, y, dict, node.val, curDepth + 1);
                DFS(node.right, x, y, dict, node.val, curDepth + 1);
            }
        }
    }



    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}