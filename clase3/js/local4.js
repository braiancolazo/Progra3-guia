const array = ["hola",3.14,true];

const array2 = new Array(3);
console.log(array2)
console.log("el array es: "+array)

const numeros = [1,35,6,54,13,3,24]
console.log("array de numeros: " + numeros)
console.log("primer elemento: "+ numeros[0])
console.log("indice de error: "+numeros[123])
numeros.push(65)//agrega un numero al array
console.log("array actualizado "+ numeros)
numeros.unshift(33)
console.log("de vuuelta muestro todo: "+ numeros)
console.log("la cantidad de elementos es: " + numeros.length)