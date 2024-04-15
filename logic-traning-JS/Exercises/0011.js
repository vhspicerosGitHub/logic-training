// https://leetcode.com/problems/squares-of-a-sorted-array/
/**
 * @param {number[]} nums
 * @return {number[]}
 */
const sortedSquares = function (nums) {
  nums = nums.map(x => x * x)
  const ascendingSortedNumbers = [...nums].sort((a, b) => a - b)
  return ascendingSortedNumbers
}

console.log(sortedSquares([-4, -1, 0, 3, 10]))
