import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {
        System.out.println("Comienzo programa...");
        ArrayList<Usuario> listaUsuario = new ArrayList<>();
        listaUsuario.add(new Usuario(1,"Javier","Rosenstein"));
        listaUsuario.add(new Usuario(2,"Elio","Togno"));
        listaUsuario.add(new Usuario(3,"Jesus","Colmenares"));

        for (Usuario usuario:listaUsuario ) {
            System.out.println(usuario.MostrarValorUsuario());
        }
    }
}