import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {
        System.out.println("Comienzo programa...\n");
        ArrayList<Usuario> listaUsuario = new ArrayList<>();
        Usuario usuario1 = new Usuario();
        usuario1.setNombre("Elio");
        usuario1.setApellido("Togno");
        usuario1.setEdad(29);
        listaUsuario.add(usuario1);
        listaUsuario.add(new Usuario("Jesus","Colmenares",24));

        for (Usuario usuario:listaUsuario ) {
            System.out.println(usuario.MostrarValorUsuario());
        }
    }
}