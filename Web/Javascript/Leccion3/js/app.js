const ingresos = [
    new Ingreso("Salario", 3100),
    new Ingreso("Venta canaima", 600)
];
const egresos = [
    new Egreso("Renta", 900),
    new Egreso("Ropa", 40)
];

let CargarApp = () =>
{
    CargarCabecero();
}
let TotalIngresos = () =>
{
    let totalIngreso = 0;
    for(let ingreso of ingresos)
    {
        totalIngreso+= ingreso.valor;
    }
    return totalIngreso;
}
let TotalEgresos = () =>
{
    let totalEgreso = 0;
    for(let egreso of egresos)
    {
        totalEgreso+= egreso.valor;
    }
    return totalEgreso;
}
let CargarCabecero = () =>
{
    let presupuesto = TotalIngresos() - TotalEgresos();
    let porcentajeEgreso = TotalEgresos()/TotalIngresos();
    document.getElementById('presupuesto').innerHTML = presupuesto;
    document.getElementById("porcentaje").innerHTML = porcentajeEgreso * 100;
    document.getElementById("ingresos").innerHTML = TotalIngresos();
    document.getElementById("egresos").innerHTML = TotalEgresos();
}
