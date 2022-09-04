// Objeto Literal en JS
let datos = {};
// Vector
let usuarios = []; 

// querySelector se usa para asignar a una variable una etiqueta ya se por id o por class
const formulario = document.querySelector("#formRegistro");

formulario.addEventListener("submit", (e) => {
    e.preventDefault();

    const identificacion = document.querySelector("#identificacion").value;
    const nombres = document.querySelector("#nombres").value;
    const apellidos = document.querySelector("#apellidos").value;
    const CorreoElectronico = document.querySelector("#CorreoElectronico").value;
    const Contrasena = document.querySelector("#Contrasena").value;
    const ConfirmarContrasena = document.querySelector("#ConfirmarContrasena").value;

    // Codicional
    //if(nombre === "" || apellido === "" || email === "" || edad === ""){
    if([identificacion, nombres, apellidos, CorreoElectronico, Contrasena, ConfirmarContrasena].includes("")){
        // verdadero
        mensajeInformativo("Todos los valor son obligatorios", true);
        return;
    }
    
    mensajeInformativo("Usuario Registrado con Éxito");

    datos = {
        "identificacion": identificacion,
        "nombres": nombres,
        "apellidos": apellidos,
        "Correo Electrónico": CorreoElectronico,
        "Contraseña": Contrasena,
        "Confirmar Contraseña": ConfirmarContrasena
    };

    //console.log(datos);
    usuarios.push(datos);

    formulario.reset();

    // Arrays metodos en JS
    usuarios.forEach( dato => console.log(dato));

});

// Funciones flechas 
const mensajeInformativo = (mensaje, error = null) => {
    
    const respuesta = document.querySelector('#mensaje');

    const alerta = document.createElement('p');
    
    alerta.textContent = mensaje;
    
    if(error){
        alerta.classList.add('error');
    }else{
        alerta.classList.add('correcto');
    };
    
    respuesta.appendChild(alerta);
    
    setTimeout(() => {
        alerta.remove();
    }, 3000);
}