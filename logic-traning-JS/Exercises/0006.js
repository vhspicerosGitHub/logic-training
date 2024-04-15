// https://leetcode.com/problems/add-two-numbers/
/**
 * @param {number} a
 * @param {number} b
 * @return {number}
 */
const getSum = function (a, b) {
  const arr = [a, b]
  return arr.reduce((acc, n) => acc + n)
}
console.log(getSum(1, 2))
