using System;
using BibliotecaDeClases; 


namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                float numero1;
                float numero2;
                string resultado;
                char operacion;
                Console.WriteLine("Ingrese un numero:");
                numero1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese un numero:");
                numero2 = float.Parse(Console.ReadLine());
                Console.Write("Que operacion desea realizar?\n+  -  *  /\nOpcion:");
                operacion = char.Parse(Console.ReadLine());

                resultado = Calculadora.Calcular(numero1, numero2, operacion);
                Console.WriteLine($"{resultado}\n----------------------------------------\n");
            }
            while (true);


                
                
                
        }
    }
}
