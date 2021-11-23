using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Lapiz:IAcciones
    {
        private float tamanioMina;

        public Lapiz(float tamanioMina)
        {
            this.tamanioMina = tamanioMina;
        }

        public ConsoleColor Color
        {
            get => ConsoleColor.Gray;
            set
            {
                throw new NotImplementedException();
            }
        }
        public float UnidadesDeEscritura 
        { 
          get => tamanioMina;
          set => tamanioMina = value; 
        }

        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper escrituraWrapper = new EscrituraWrapper(texto, Color);
             tamanioMina =tamanioMina - (0.1f * texto.Length);
            return escrituraWrapper;
        }

        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"El Lapiz contiene, color:Grey, nivel mina:{tamanioMina}";
        }
    }


}
