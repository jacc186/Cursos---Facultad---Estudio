using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones2
{
    class DirectorTecnico:Persona
    {
        private DateTime fechaNacimiento;

        public DirectorTecnico(string nombre, DateTime fechaNacimiento): base(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        public DirectorTecnico(string nombre): base (nombre)
        {

        }

        public static bool operator ==(DirectorTecnico d1, DirectorTecnico d2)
        {

            return (d1.fechaNacimiento == d2.fechaNacimiento) && (d1.Nombre == d2.Nombre);
        }
        public static bool operator !=(DirectorTecnico d1, DirectorTecnico d2)
        {
            return !(d1 == d2);
        }
    }

}
