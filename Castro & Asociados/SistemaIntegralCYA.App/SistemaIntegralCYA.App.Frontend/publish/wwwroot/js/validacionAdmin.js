// Objeto Literal en JS
let datos2 = {};
// Vector
let usuarios2 = []; 

// querySelector se usa para asignar a una variable una etiqueta ya se por id o por class
const formulario2 = document.querySelector("#formIngreso1");

formulario2.addEventListener("submit", (e) => {
    e.preventDefault();

    const correoElectronico = document.querySelector("#correoElectronico").value;
    const Contrasena = document.querySelector("#Contrasena").value;

    // Codicional
    //if(nombre === "" || apellido === "" || email === "" || edad === ""){
    if([correoElectronico, Contrasena].includes("")){
        // verdadero
        mensajeInformativo2("Todos los campos son obligatorios", true);
        return;
    }
    
    mensajeInformativo2("Bienvenido", redireccion2());

    datos2 = {
        "Correo Electrónico": correoElectronico,
        "Contraseña": Contrasena,

    };

    //console.log(datos);
    usuarios2.push(datos2);

    formulario2.reset();

    // Arrays metodos en JS
    usuarios1.forEach( dato => console.log(dato));

});

// Funciones flechas 
const mensajeInformativo2 = (mensaje, error = null) => {
    
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