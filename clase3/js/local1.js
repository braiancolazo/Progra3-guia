const Persona1 = {
    nombre:"juan",
    apellido: "perez",
    fechaNacimiento: new Date(1988,4,27),
    saluda: function(){
        console.log("Hola soy juan")
    }

    
}

const Persona2 = new Object()
Persona2.nombre = "nico"
Persona2.apellido = "Horenstein"
Persona2.fechaNacimiento = new Date
Persona2.saludar =function(){
    console.log("Hola me llamo nico")
}

console.log(Persona1)
console.log(Persona2)