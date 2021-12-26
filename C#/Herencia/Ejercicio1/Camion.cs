using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Camion: VehiculoTerrestre
    {
        private int pesoCarga;
        public Camion(int pesoCarga):base(cantidadRuedas, cantidadPuertas, color,cantidadMarchas)
        {
            this.pesoCarga = pesoCarga;
        }        
    }
}
