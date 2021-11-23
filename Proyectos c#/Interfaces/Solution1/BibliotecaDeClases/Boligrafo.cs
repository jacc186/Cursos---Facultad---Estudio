using System;

namespace BibliotecaDeClases
{
    public class Boligrafo: IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(int unidades, ConsoleColor color)
        {
            Color = color;
            UnidadesDeEscritura = (float)unidades;
        }

        public ConsoleColor Color { get => colorTinta; set => colorTinta = value;}
        public float UnidadesDeEscritura { get => tinta; set => tinta = value; }
        ConsoleColor IAcciones.Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        float IAcciones.UnidadesDeEscritura { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper escrituraWrapper = new EscrituraWrapper(texto,colorTinta);
            tinta = tinta - (0.3f * texto.Length);
            return escrituraWrapper;            
        }

        public bool Recargar(int unidades)
        {
            if(unidades>0)
            {
                tinta = tinta + (float)unidades;
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return $"El boligrafo contiene, color:{colorTinta}, nivel tinta:{tinta}";
        }
    }
}
