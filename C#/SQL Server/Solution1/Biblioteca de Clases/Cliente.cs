namespace Biblioteca_de_Clases
{
    public class Cliente
    {
        private int id;
        private string nombre;
        private string apellido;
        private string direccion;
        private long telefono;

        public Cliente(string nombre, string apellido, string direccion, long telefono)
        {
            this.id = 0;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public Cliente(int id, string nombre, string apellido, string direccion, long telefono) : this(nombre, apellido, direccion, telefono)
        {
            this.id = id;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public long Telefono { get => telefono; set => telefono = value; }
    }
}
