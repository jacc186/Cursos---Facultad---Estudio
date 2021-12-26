using System;
using BibliotecaDeClases;
namespace Consola
{
    class Consola1
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ingrese un número: ");
            if(int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine(LasTablas.TablaDeMultiplicar(numero));
            }
            Console.ReadKey();
        }
    }
}
