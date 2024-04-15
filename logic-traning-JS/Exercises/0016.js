// https://leetcode.com/problems/maximum-number-of-balloons/

/**
 * @param {string} text
 * @return {number}
 */
const maxNumberOfBalloons = function (text) {
  const magicWord = 'Balloons'.toLowerCase()
  text = text.toLowerCase()

  // Considerrer if lenght of text is menor magixword.. return 0
  // 1.- Check Max posibilities we can found thwe maggioc word
  // 2.- Iteterate
  console.log(text)
  if (text.length < magicWord) { return 0 }
  let counterMagicWord = 0
  const maxPosibilitiesGetMagicCounter = text.length / magicWord.length

  for (let i = 0; i < maxPosibilitiesGetMagicCounter; i++) {
    let found = true
    for (let j = 0; j < magicWord.length - 1; j++) {
      const character = magicWord[j]
      const characterPosition = text.indexOf(character)
      console.log({ i, j, characterPosition, character, text })
      if (characterPosition === -1) {
        found = false
      } else {
        text = text.slice(0, characterPosition) + text.slice(characterPosition + 1, text.length)
      }
    }
    if (found) {
      counterMagicWord++
    }
  }
  return counterMagicWord
}

console.log('CANTIDAD ==> ' + maxNumberOfBalloons('nlaebolko'))
