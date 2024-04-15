// https://leetcode.com/problems/binary-subarrays-with-sum/

/**
 * @param {number[]} nums
 * @param {number} goal
 * @return {number}
 */
const numSubarraysWithSum = function (nums, goal) {
  const arr = []
  let sum = 0
  const dict = {}
  const dictrest = {}
  let counter = 0
  dict[0] = 1

  for (let i = 0; i < nums.length; i++) {
    sum = sum + nums[i]
    const res = sum - goal
    arr.push(sum)

    console.log({ nums, i, sum, res, arr, dict, dictrest, counter })

    if (res in dict) {
      counter = counter + dict[res]
      console.log('nuevo counter ==>' + counter)
    }

    if (sum in dict) {
      dict[sum] = dict[sum] + 1
    } else {
      dict[sum] = 1
    }

    if (res in dictrest) {
      dictrest[res] = dictrest[res] + 1
    } else {
      dictrest[res] = 1
    }
  }

  return counter
}
console.log('hola')
console.log('COUNTER==>' + numSubarraysWithSum([1, 0, 1, 0, 1], 2))
// console.log('COUNTER==>' + numSubarraysWithSum([0, 0, 0, 0, 0], 0))
