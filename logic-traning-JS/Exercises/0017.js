// https://leetcode.com/problems/univalued-binary-tree/

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
 * @return {boolean}
 */
const isUnivalTree = function (root) {
  const level = 0
  return checkNode(root, root.val, level)
}

/**
* @param {TreeNode} node
* @param {number} value
 * @return {boolean}
 */
const checkNode = function (node, value, level) {
  console.log(level)
  level++
  if (node === null) { return true }
  if (node.val !== value) { return false }
  return checkNode(node.left, node.val, level) && checkNode(node.right, node.val, level)
}
