public class Usuario {
    private String Nombre;
    private String Apellido;

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String nombre) {
        Nombre = nombre;
    }

    public String getApellido() {
        return Apellido;
    }

    public void setApellido(String apellido) {
        Apellido = apellido;
    }

    public Integer getEdad() {
        return Edad;
    }

    public void setEdad(Integer edad) {
        Edad = edad;
    }

    private Integer Edad;

    public Usuario() {
        this("","",0);
    }
    public Usuario(String nombre, String apellido, Integer edad) {
        Edad = edad;
        Nombre = nombre;
        Apellido = apellido;
    }

    public String MostrarValorUsuario(){
        return "Nombre: " + Nombre + "\nApellido: " + Apellido + "\nEdad: " + Edad + "\n------------------------------";
    }

}
