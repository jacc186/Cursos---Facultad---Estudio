import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {
        System.out.println("Comienzo programa...\n");
        ArrayList<Telefono> listaTelefono = new ArrayList<>();
        Telefono telefono1 = new Telefono();
        telefono1.setNombre("Elio");
        telefono1.setApellido("Togno");
        telefono1.setEdad(29);
        listaTelefono.add(telefono1);
        listaTelefono.add(new Telefono("Jesus","Colmenares",24));

        for (Telefono telefono : listaTelefono) {
            System.out.println(telefono.MostrarValorUsuario());
        }
    }
}