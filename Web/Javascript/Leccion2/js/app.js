const personas = [
    new Persona("Jesus", "Colmenares"),
    new Persona("Carla", "Juarez")
];

function MostrarPersonas()
{
    let texto = "";

    for(let persona of personas)
    {
        texto += `<li> ${persona.nombre} ${persona.apellido}</li>`;
    }
    document.getElementById("personas").innerHTML = texto;
}

function AgregarPersona()
{
    let nombre = document.getElementById("nombre").value;
    let apellido = document.getElementById("apellido").value;
    personas.push(new Persona(nombre, apellido));
    MostrarPersonas();
}