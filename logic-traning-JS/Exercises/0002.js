/**
 * @param {number[]} numbers
 * @param {number} count
 * @return {number}
 */
const getMaxWithSort = (numbers, count) => {
  numbers.sort()
  numbers.reverse()
  return numbers.slice(0, count)
}

console.log(getMaxWithSort([1, 1, 4, 2, 1, 3], 1))
