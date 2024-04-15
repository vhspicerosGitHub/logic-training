// https://leetcode.com/problems/cousins-in-binary-tree/
/**
 * Definition for a binary tree node.
 * function TreeNode(val, left, right) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.left = (left===undefined ? null : left)
 *     this.right = (right===undefined ? null : right)
 * }
 */
/**
 * @param {TreeNode} root
 * @param {number} x
 * @param {number} y
 * @return {boolean}
 */
const isCousins = function (root, x, y) {
  const [xDepth, xParent] = findParentAndDepth(root, x)
  const [yDepth, yParent] = findParentAndDepth(root, y)
  return xDepth === yDepth && xParent !== yParent
}

const findParentAndDepth = (curNode, value, curDepth = 0, parentValue) => {
  if (!curNode) return
  if (curNode.val === value) return [curDepth, parentValue]
  return (
    findParentAndDepth(curNode.left, value, curDepth + 1, curNode.val) ||
    findParentAndDepth(curNode.right, value, curDepth + 1, curNode.val)
  )
}
