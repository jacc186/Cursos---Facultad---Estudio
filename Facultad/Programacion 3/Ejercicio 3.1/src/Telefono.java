public class Telefono {
    private String Marca;
    private String Modelo;
    private Double Saldo;
    private String NumeroTelefono;
    private String Titular;
    public Telefono() {
        this("","",0);
    }
    public Telefono(String marca, String modelo, Double saldo) {
        this(marca,modelo,saldo,"","");
    }
    public Telefono(String marca, String modelo, Double saldo,String numeroTelefono,String titular) {
        Saldo = saldo;
        Marca = marca;
        Modelo = modelo;
        NumeroTelefono = numeroTelefono;
        Titular = titular;
    }
    public String IngresarTelefono(String nuevo_telefono){
        Telefono = nuevo_telefono;
        return "Telefono Actualizado.";
    }
• CambiarTitular(String nuevo_titular) -> En el cual debe usarse para ingresar o actualizar el
    nombre del titular.
• IngresarSaldo(double saldoIngresado) -> Se ingresa una cantidad al saldo disponible, en el
    caso de que sea cero, sino debe sumarse a la cantidad que se disponía. En el caso de que sea
    cero no debe hacer nada. Debe devolver la cantidad de saldo actualizado.
• RestarSaldo(double saldoRetirado) -> Debe restar del saldo disponible, si retirando de la
    cantidad actual pasa a negativo, la cantidad del saldo debe ser cero. Debe devolver la
    cantidad de saldo restante.


    public String getMarca() {
        return Marca;
    }

    public void setMarca(String marca) {
        Marca = marca;
    }

    public String getModelo() {
        return Modelo;
    }

    public void setModelo(String modelo) {
        Modelo = modelo;
    }

    public Double getSaldo() {
        return Saldo;
    }

    public void setSaldo(Double saldo) {
        Saldo = saldo;
    }

    public String getNumeroTelefono() {
        return NumeroTelefono;
    }

    public void setNumeroTelefono(String numeroTelefono) {
        NumeroTelefono = numeroTelefono;
    }

    public String getTitular() {
        return Titular;
    }

    public void setTitular(String titular) {
        Titular = titular;
    }
}
