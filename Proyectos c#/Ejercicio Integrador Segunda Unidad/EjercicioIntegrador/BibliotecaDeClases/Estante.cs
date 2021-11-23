using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    class Estante
    {
        private int ubicacionEstante;
        Producto[] productos;

        public Estante(int capacidad, int ubicacion):this(capacidad)
        {
            ubicacionEstante = ubicacion;
        }
        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }
        public Producto[] GetProductos()
        {
            return productos;
        }
        public string MostrarEstante(Estante e)
        {
            return $"{e.productos}{e.ubicacionEstante}";
        }
    }
}
