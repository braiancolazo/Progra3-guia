const numeros = [1,35,6,54,13,3,24]
const mayoresA10 = numeros.filter((e) => e >10)
console.log("los numeros: " + numeros)
console.log("mayores a 10: "+ mayoresA10)
const numerosPor10= numeros.map((e) => e*10)
console.log("los numeros: " + numeros)
console.log("Numeros multiplicados por 10: "+ numerosPor10)
