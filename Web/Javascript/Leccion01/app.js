function Sumar()
{
    if(isNaN(parseInt(document.forms["forma"][0].value)) || isNaN(parseInt(document.forms["forma"][1].value)))
    {
        document.getElementById("resultado").innerHTML = "No se han completado los campos";
    }
    else
    {
        document.getElementById("resultado").innerHTML = "Resultado: " + (parseInt(document.forms["forma"][0].value) + parseInt(document.forms["forma"][1].value));
    }
}