using System;
using ConversorBinario;
namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string binario;
            int deci;
            Console.WriteLine("Ingrese un número decimal: ");
            deci = int.Parse(Console.ReadLine());
            binario = ConversorBinario.Conversor.ConvertirDecimalABinario(deci);
            Console.WriteLine($"En binario es: {binario}");
            Console.WriteLine("Ingrese un número binario: ");
            deci = int.Parse(Console.ReadLine());
            deci = ConversorBinario.Conversor.ConvertirBinarioADecimal(deci);
            Console.WriteLine($"En decimal es: {deci}");
        }
    }
}
