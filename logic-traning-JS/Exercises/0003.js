/**
 * @param {number[]} numbers
 * @param {number} count
 * @return {number}
 */
const isPalindrome = (numbers) => {
  const reverse = [...numbers]
  reverse.reverse()
  for (let index = 0; index < numbers.length; index++) {
    if (numbers[index] !== reverse[index]) { return false }
  }
  return true
}

console.log(isPalindrome([1, 1, 4, 2, 1, 3]))
console.log(isPalindrome([1, 1, 4, 4, 1, 1]))
