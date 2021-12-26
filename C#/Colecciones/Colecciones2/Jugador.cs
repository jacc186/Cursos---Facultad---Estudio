using System;

namespace Colecciones2
{       
        
    public class Jugador:Persona
    {
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;
        public int PartidosJugados
        {
            get
            {
                return partidosJugados;
            }
            set
            {
                partidosJugados = value;

            }
        }

        public float PromedioGoles
        {
            get
            {
                return promedioGoles;
            }
        }
        public int TotalGoles
        {
            get
            {
                return totalGoles;
            }
            set
            {
                totalGoles = value;
            }
        }

        private Jugador()
        {
            partidosJugados = 0;
            totalGoles = 0;
        }

        public Jugador(int dni, string nombre):this()
        {            
            this.dni = dni;
            this.nombre = nombre;
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos):this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public float GetPromedioGoles()
        {
            return totalGoles / partidosJugados;
        }

        public string MostrarDatos()
        {
            return $""
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1==j2);
        }
    }    

}
