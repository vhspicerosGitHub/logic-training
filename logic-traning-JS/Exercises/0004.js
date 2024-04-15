/**
 * https://leetcode.com/problems/add-to-array-form-of-integer/
 * @param {number[]} num
 * @param {number} k
 * @return {number[]}
 */
const addToArrayForm = function (num, k) {
  const number = BigInt(num.map((x) => x.toString()).join('')) + BigInt(k)
  return number.toString().split('')
}

console.log(addToArrayForm([1, 2, 0, 0], 34))

const num = [1, 2, 6, 3, 0, 7, 1, 7, 1, 9, 7, 5, 6, 6, 4, 4, 0, 0, 6, 3]
const k = 516
console.log(addToArrayForm(num, k))
