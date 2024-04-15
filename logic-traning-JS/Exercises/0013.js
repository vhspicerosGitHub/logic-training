// https://leetcode.com/problems/duplicate-zeros/
/**
 * @param {number[]} arr
 * @return {void} Do not return anything, modify arr in-place instead.
 */
const duplicateZeros = function (arr) {
  if (!arr.includes(0)) { return arr }

  const arrayReturn = []
  for (let i = 0; i < arr.length; i++) {
    if (arrayReturn.length < arr.length) {
      arrayReturn.push(arr[i])
      if (arr[i] === 0) {
        arrayReturn.push(arr[i])
      }
    }
  }
  for (let i = 0; i < arr.length; i++) {
    arr[i] = arrayReturn[i]
  }
  console.log(arr)
  return arr
}

duplicateZeros([1, 0, 2, 3, 0, 4, 5, 0])
