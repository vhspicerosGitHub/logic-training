/**
 * @param {number[]} heights
 * @return {number}
 */
const getMax = (numbers) => { return Math.max(...numbers) }

/**
 * @param {number[]} heights
 * @return {number}
 */
const getMaxWithFor = (numbers) => {
  let max = Infinity * -1
  numbers.forEach(element => {
    if (element > max) { max = element }
  })
  return max
}

/**
 * @param {number[]} heights
 * @return {number}
 */
const getMaxWithSort = (numbers) => {
  numbers.sort()
  numbers.reverse()
  return numbers[0]
}

console.log(getMax([1, 1, 4, 2, 1, 3]))
console.log(getMaxWithFor([1, 1, 4, 2, 1, 3]))
console.log(getMaxWithSort([1, 1, 4, 2, 1, 3]))
