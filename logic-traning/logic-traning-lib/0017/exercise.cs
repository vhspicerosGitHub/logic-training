using System;
using System.ComponentModel;
using System.Runtime.Loader;
using static logic_traning_lib._0012.exercise;

namespace logic_traning_lib._0017
    ;
internal class exercise
{


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

    /// <summary>
    /// https://leetcode.com/problems/univalued-binary-tree/
    /// </summary>

    public class Solution
    {
        public bool IsUnivalTree(TreeNode root)
        {
            var head = root;
            var currnent = head;
            var value = head.val;
            return CheckNode(currnent, value);
        }

        private bool CheckNode(TreeNode? node, int val)
        {
            if (node == null)
                return true;
            if (node.val != val)
                return false;
            return CheckNode(node.left, val) && CheckNode(node.right, val);
        }

    }
}
