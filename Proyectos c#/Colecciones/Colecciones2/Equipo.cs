using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones2
{
    class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;

        private Equipo()
        {

        }
        public Equipo(short cantidadDeJugadores, List<Jugador> jugadores)
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.jugadores = jugadores;
        }
    }
}
