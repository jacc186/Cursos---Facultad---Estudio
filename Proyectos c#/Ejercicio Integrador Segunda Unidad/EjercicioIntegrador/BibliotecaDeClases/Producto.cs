using System;

namespace BibliotecaDeClases
{
    public class Producto
    {
        private string codigoDeBarras;
        private string marca;
        private float precio;

        public Producto(string codigoDeBarras, string marca, float precio)
        {
            this.codigoDeBarras = codigoDeBarras;
            this.marca = marca;
            this.precio = precio;
        }
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarras;
        }     
        public static bool operator ==(Producto p1, Producto p2)
        {
            if(p1.marca == p2.marca && (string)p1 == (string)p2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Producto p1, string marca)
        {
            if(p1.marca == marca)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1 == marca);
        }
            
        public string Marca { get => marca; }
        public float Precio { get => precio; }
        public static string MostrarProducto(Producto p)
        {
            return $"Marca: {p.Marca}\nPrecio: {p.Precio}\nCodigo de Barras:{(string)p}";
        }
    }
}
