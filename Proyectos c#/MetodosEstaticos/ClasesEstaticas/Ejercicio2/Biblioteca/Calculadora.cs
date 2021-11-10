using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class Calculadora
    {
        public static string Calcular(float numero1, float numero2, char operacion)
        {
            string resultado = "";
            switch (operacion)
            {
                case '+': 
                    resultado = (numero1 + numero2).ToString();
                    break;
                case '-':
                    resultado = (numero1 - numero2).ToString();
                    break;
                case '*':
                    resultado = (numero1 * numero2).ToString();
                    break;
                case '/':
                    if(Validar(numero2))
                    {
                        resultado = (numero1 / numero2).ToString();
                    }
                    else
                    {
                        resultado = "El segundo numero no puede ser cero";
                    }
                    break;
                default:
                    break;
            }
            return resultado;
        }
        private static bool Validar(float numero2)
        {
            return numero2 != 0;
        }
    }
}
