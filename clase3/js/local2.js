class Persona  {
    constructor(nombre,apellido,correo){
        this.nombre = nombre
        this.apellido = apellido
        this.correo = correo

    }
}

const p = new Persona("nico","horenstein", "nicolashorenstein@gmail.com")
console.log(p)