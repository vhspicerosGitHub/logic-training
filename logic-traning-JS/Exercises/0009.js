/**
 * @param {number} num
 * @return {number}
 */
const isPrimeNumber = function (num) {
  for (let i = 2; i < num - 1; i++) {
    if (num % i === 0) { return false }
  }
  return true
}

console.log(isPrimeNumber(2))
console.log(isPrimeNumber(5))
console.log(isPrimeNumber(7))
console.log(isPrimeNumber(10))
