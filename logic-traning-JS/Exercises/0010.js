// leetcode.com/problems/numbers-with-repeated-digits/

/**
 * @param {number} n
 * @return {number}
 */
const numDupDigitsAtMostN = function (n) {
  if (n < 11) return 0

  let counter = 0
  for (let i = n; i >= 11; i--) {
    if (hasDiplicates(i)) {
      counter++
    }
  }
  return counter
}

const hasDiplicates = function (n) {
  if (removeDuplicate(n).length !== n.toString().length) {
    return true
  }
  return false
}

const removeDuplicate = function (data) {
  return [...new Set(data.toString())]
}
console.log(numDupDigitsAtMostN(20))
console.log(numDupDigitsAtMostN(100))
