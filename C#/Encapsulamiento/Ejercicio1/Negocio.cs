using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes
        {
            get
            {
                return clientes;
            }
            set
            {
                this.clientes = value;
            }
        }
        private string nombre;

        

        public Negocio(string nombre)
        {
            this.nombre = nombre;
        }
        private Negocio() : this("")
        {
        }
    }
}
