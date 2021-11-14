using System;
using System.Text;
namespace ConversorBinario
{
    public static class Conversor
    {
        
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            double resultado = 0;
            int indice = 1;
            int valor;
            while(numeroEntero >= 1)
            {
                if(numeroEntero%2 == 0)
                {
                    valor = 0;
                    resultado = resultado + (valor * indice); 
                }
                else
                {
                    valor = 1;
                    resultado = resultado + (valor * indice);
                }
                numeroEntero /= 2;
                indice *= 10;
            }
            return resultado.ToString();
        }
        public static int ConvertirBinarioADecimal(int binario)
        {
            int exp, digito;
            double resultado = 0;
            exp = 0;
            while (binario > 0)
            {
                digito = (int)binario % 10;
                resultado = resultado + digito * Math.Pow(2.0, exp);
                exp++;
                binario = binario / 10;
            }
            return (int)resultado;
        }
    }
}
