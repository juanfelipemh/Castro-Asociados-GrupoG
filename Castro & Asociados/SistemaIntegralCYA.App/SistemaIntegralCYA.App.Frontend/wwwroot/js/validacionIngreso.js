// Objeto Literal en JS
let datos1 = {};
// Vector
let usuarios1 = []; 

// querySelector se usa para asignar a una variable una etiqueta ya se por id o por class
const elemento = document.querySelector("#formIngreso");

elemento.addEventListener("submit", (e) => {
    e.preventDefault();

    const CorreoElectronico = document.querySelector("#CorreoElectronico").value;
    const Contrasena = document.querySelector("#Contrasena").value;

    // Codicional
    //if(nombre === "" || apellido === "" || email === "" || edad === ""){
    if([CorreoElectronico, Contrasena].includes("")){
        // verdadero
        mensajeInformativo1("Todos los campos son obligatorios", true);
        return;
    }
    
    mensajeInformativo1("Bienvenido", redireccion());

    datos1 = {
        "Correo Electrónico": CorreoElectronico,
        "Contraseña": Contrasena,

    };

    //console.log(datos);
    usuarios1.push(datos1);

    formulario1.reset();

    // Arrays metodos en JS
    usuarios1.forEach( dato => console.log(dato));

});

// Funciones flechas 
const mensajeInformativo1 = (mensaje, error = null) => {
    
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
