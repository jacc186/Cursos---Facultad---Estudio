using System;
using BibliotecaDeClases; 


namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero1;
            float numero2;
            string resultado;
            char operacion;
            do
            {
                Console.WriteLine("Ingrese un numero:");
                numero1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese un numero:");
                numero2 = float.Parse(Console.ReadLine());
                Console.Write("Que operacion desea realizar?\n+  -  *  / n=salir\nOpcion:");
                operacion = char.Parse(Console.ReadLine());

                resultado = Calculadora.Calcular(numero1, numero2, operacion);
                Console.WriteLine($"El resultado es: {resultado}\n----------------------------------------\n");
            }
            while (operacion != 'n');


                
                
                
        }
    }
}
