using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class LasTablas
    {
        public static string TablaDeMultiplicar(int numero)
        {
            StringBuilder stringBuilder = new StringBuilder(); 
            for (int i=0; i<=10; i++)
            {
                stringBuilder.AppendFormat("{0} x {1} = {2}{3}", numero, i, numero*i, Environment.NewLine);
            }
            return stringBuilder.ToString();
        }
    }
}
