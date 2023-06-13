public class Usuario {
    private Integer IdUsuario;
    private String Nombre;
    private String Apellido;

    public Usuario(Integer idUsuario, String nombre, String apellido) {
        IdUsuario = idUsuario;
        Nombre = nombre;
        Apellido = apellido;
    }

    public String MostrarValorUsuario(){
        return "Usuario id: " + IdUsuario.toString() + "\nNombre: " + Nombre + "\nApellido: " + Apellido + "\n------------------------------";
    }

}
