function generateArray (number) {
  return Array.from({ length: number }, (_, index) => (index + 1) * 10)
}

function getIndex (array, key) {
  return array.indexOf(key)
}

const multiply = (array1, multiply) => {
  return array1.map((a) => a * multiply)
}

const r = generateArray(10)
console.log(multiply(r, 2))

// multiplica por dos cada elemento
console.log(([1, 2, 3, 4]).map(x => x * 2))

// Filtra la comida que no sea carne
console.log((['🥝', '🍎', '🍖']).filter(x => x !== '🍖'))

// encuentra y devuelve la gallinna
console.log(['🐔', '🏸'].find(x => x === '🐔'))

// Encuentra el indice de la gallina
console.log(['🐔', '🏸'].findIndex(x => x === '🐔'))
console.log(['🐔', '🏸'].indexOf('🐔'))

// todos los valores son iguales
console.log([1, 1, 1, 2, 1].every(x => x === 1))

// Existe un 2
console.log([1, 1, 1, 2, 1].every(x => x === 2))
