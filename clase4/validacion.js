function validarformularios(){
    const txtNombre = document.getElementById("txtNombre")
    const txtApellido = document.getElementById("txtApellido")
    const rbSexo = document.getElementsByName("sexo")
    const txtDescripcion = document.getElementById("txtDescripcion")
    const selectDeportes = document.getElementById("deportes")



    if(txtNombre.value === ''){
        alert("El nombre es requerido")
        return false;
    }

    if(txtApellido.value ===''){
        alert("El apellido es requerido")
        return false;
    }

    if(txtDescripcion.value ===''){
        alert("La descripcion es requerido")
        return false;
    }
    let algunochekeado = false
    for(let i =0;i<rbSexo.length;i++){
        if(rbSexo[i].checked){
            algunochekeado = true;
            break;
        }
    }

    if(algunochekeado == false){
        alert("Debe seleccionar un sexo")
        return false
    }

    return true
}

function guardar(){
    
    if(validarformularios()){
        
        Swal.fire({
            title: 'Genial!',
            text: 'persona registrada correctamente',
            icon: 'success',
            confirmButtonText: 'Cool'
          })
    }
    else{
        Swal.fire({
            title: 'Error!',
            text: 'Faltan completar campos',
            icon: 'error',
            confirmButtonText: 'Cool'
          })
    }

}