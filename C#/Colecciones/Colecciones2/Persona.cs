using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones2
{
    class Persona
    {
        private long dni;
        private string nombre;
        public long Dni
        {
            get
            {
                return dni;
            }
            set
            {
                dni = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        

        public Persona(long dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Persona(string nombre):this(0, nombre)
        {
        }

        public string MostrarDatos()
        {
            return $"DNI {dni} - Nombre {nombre}";
        }
    }
}
