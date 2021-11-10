using System;
namespace Biblioteca
{
    public static class CalculadoraDeArea
    {
        
        public static double CalcularAreaCuadrado(double longitud)
        {
            return longitud * 2;
        }
        public static double CalcularAreaTriangulo(double h, double x)
        {
            return (x*h)/2 ;
        }
        public static double CalcularAreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio,2);
        }
    }
}
