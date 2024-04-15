// https://leetcode.com/problems/defanging-an-ip-address/
// https://leetcode.com/problems/defanging-an-ip-address/
/**
 * @param {string} address
 * @return {string}
 */
const defangIPaddr = function (address) {
  const foo = address.replaAll('.', '[.]')
  return foo
  // return address.split('.').join('[.]')
}
