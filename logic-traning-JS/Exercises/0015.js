// https://leetcode.com/problems/day-of-the-week/
/**
 * @param {number} day
 * @param {number} month
 * @param {number} year
 * @return {string}
 */
const dayOfTheWeek = function (day, month, year) {
  const days = ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday']

  const d = new Date(`${month},${day},${year}`)
  const dayy = d.getDay()
  return days[dayy]
}
